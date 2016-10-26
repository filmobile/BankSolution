using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    [Serializable]
    public class CurrencyRate
    {
        public decimal ExchangeRate { get; set; }

        public CurrencyRate(decimal rate)
        {
            ExchangeRate = rate;
        }
    }
}
