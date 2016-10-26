using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    [Serializable]
    public class Bank

    {
        private uint lastAccountId;
        private List<Account> accounts;
        private object transactionLocker = new object();
        public List<Client> Clients { get; private set; }
        public IEnumerable<Account> Accounts { get { return accounts.AsReadOnly(); } }
        public Dictionary<Currency, CurrencyRate> CurrencyRates { get; private set; }
        private List<Transaction> historyTransactions;  // history of transactions
        public IEnumerable<Transaction> HistoryTransactions { get { return historyTransactions.AsReadOnly(); } }
        private List<Transaction> historyOfCanceledTransactions; // history of cancelled transactions 
        public IEnumerable<Transaction> HistoryOfCancelledTransactions { get { return historyOfCanceledTransactions.AsReadOnly(); } }
        public Bank()
        {
            Clients = new List<Client>();
            accounts = new List<Account>();
            CurrencyRates = new Dictionary<Currency, CurrencyRate>();
            historyTransactions = new List<Transaction>();
            historyOfCanceledTransactions = new List<Transaction>();
        }

        /// <summary>
        /// Перевод со счета на счет (сумма в валюте отправителя)
        /// </summary>
        public Transaction MakeTransaction(Account from, Account to, decimal sum)
        {
            var rate = CurrencyRates[to.Currency].ExchangeRate / CurrencyRates[from.Currency].ExchangeRate;

            lock (transactionLocker)//для предотвращения одновременного снятия денег из разных потоков
            {
                if (sum <= 0)
                    throw new Exception("Summa must be greater than 0");

                if (from.Balance < sum)
                    throw new Exception("Balance is not enough for the transaction");

                from.Balance -= sum;
                to.Balance += sum * rate;

                var tr = new Transaction(from, to, sum * rate);
                historyTransactions.Add(tr);
                return tr;
            }
        }

        /// <summary>
        /// Взнос наличными (в валюте аккаунта)
        /// </summary>
        public Transaction MakeTransaction(Account to, decimal sum)
        {
            if (sum <= 0)
                throw new Exception("Summa must be greater than 0");

            to.Balance += sum;

            var tr = new Transaction(null, to, sum);

            return tr;
        }

        // cancel transaction
        public Transaction CancelTransaction(Transaction trans)
        {

            var rate = CurrencyRates[trans.To.Currency].ExchangeRate / CurrencyRates[trans.From.Currency].ExchangeRate;
            if (trans.To.Balance < trans.Summa)
                throw new Exception("Balance is not enough for cancel transaction");
            trans.To.Balance -= trans.Summa;
            trans.From.Balance += trans.Summa / rate;
            historyOfCanceledTransactions.Add(trans);
            historyTransactions.Remove(trans);
            return trans;
        }

        public Account CreateAccount(Currency currency, Client client)
        {
            var acc = new Account(this, currency, client);
            lastAccountId++;
            acc.Id = lastAccountId.ToString();
            accounts.Add(acc);
            return acc;


        }

    }
}
