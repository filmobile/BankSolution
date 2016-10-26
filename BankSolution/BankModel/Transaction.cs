using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    [Serializable]
    public class Transaction
    {
        public Account From { get; private set; }
        public Account To { get; private set; }
        public Decimal Summa { get; private set; }//в валюте получателя


        internal Transaction(Account from, Account to, decimal summa)
        {

            From = from;
            To = to;
            Summa = summa;
        }
    }
    [Serializable]
    public enum Currency { US, EU, UA }
}
