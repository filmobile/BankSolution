using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    [Serializable]
    public class Account
    {
        public decimal Balance { get; internal set; }
        public Client Client { get; private set; }
        public Currency Currency { get; private set; }
        public Bank Bank { get; private set; }
        public string Id { get; internal set; }

        internal Account(Bank bank, Currency currency, Client client)
        {
            Bank = bank;
            Currency = currency;
            Client = client;
        }
    }
}
