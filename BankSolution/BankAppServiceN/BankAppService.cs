using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BankModel;
using BankAppServiceNS.Commands;
using System.Configuration;
using BankAppServiceNS.Properties;



namespace BankAppServiceNS
{
    public class BankAppService : IDisposable
    {
        Bank bank;
        public BankAppService()
        {
            var filePath =Settings.Default.DataBaseFilePath;
            if (File.Exists(filePath))
                using (var fs = new FileStream(filePath, FileMode.Open))
                    bank = (Bank)new BinaryFormatter().Deserialize(fs);
            else
                bank = new Bank();

        }

        public void SignUp(string userLogin, string password)
        {
            if (bank.Clients.Any(p => p.Name == userLogin))
                throw new Exception("Client with this name exists yet!");

            Client client = new Client() { Name = userLogin, Password = password };
            bank.Clients.Add(client);
        }

        public void Login(string userLogin, string password)
        {
            if (!bank.Clients.Any(p => p.Name == userLogin && p.Password == password))
                throw new Exception("Bad login or password");
        }

        public void CreateAccount(string userLogin, Currency currency)
        {
            var client = bank.Clients.Where(p => p.Name == userLogin).First();
            bank.CreateAccount(currency, client);
        }

        public decimal GetBalance(string accountId)
        {
            var balance = bank.Accounts.First(p => p.Id == accountId).Balance;
            return balance;
        }

        public void CreateFirstTransaction(decimal sum, string accountId)
        {
            var account = bank.Accounts.First(p => p.Id == accountId);
            bank.MakeTransaction(account, sum);

        }

        public List<AccountDTO> GetClientAccounts(string userLogin)
        {
            var list = new List<AccountDTO>();
            foreach (var p in bank.Accounts.Where(p => p.Client.Name == userLogin))
            {
                list.Add(new AccountDTO(p));
            }
            return list;
        }

        public List<MadeTransactionDTO> GetMadeTransaction(string userLogin)
        {
            var list = new List<MadeTransactionDTO>();
            foreach (var p in bank.HistoryTransactions.Where(p=>p.From.Client.Name==userLogin))
            {
                list.Add(new MadeTransactionDTO(p));
                
            }
            return list;
        }

        public void CreateTransaction(string fromAccountId, string toAccountId, decimal sum)
        {
            if (fromAccountId == toAccountId)
                throw new Exception("Can not transfer money to same account");

            var accountFrom = bank.Accounts.First(p => p.Id == fromAccountId);
            var accountTo = bank.Accounts.First(p => p.Id == toAccountId);
            bank.MakeTransaction(accountFrom, accountTo, sum);
        }

        public void WriteBankData()
        {
            var filePath = Settings.Default.DataBaseFilePath;
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = File.OpenWrite(filePath))
            {
                formatter.Serialize(fs, bank);
            }
        }

        public void SetCurrency( decimal US,decimal EU,decimal UA)
        {
            bank.CurrencyRates[Currency.US] = new CurrencyRate(US);
            bank.CurrencyRates[Currency.EU] = new CurrencyRate(EU);
            bank.CurrencyRates[Currency.UA] = new CurrencyRate(UA);
        }
       

        public void Dispose()
        {
            WriteBankData();
        }

    }
}
