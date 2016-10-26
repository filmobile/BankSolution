using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;

namespace BankAppServiceNS.Commands
{
    [Serializable]
    public class SetCurrencyCommand : Command
    {
        public decimal US { get; set; }
        public decimal EU { get; set; }
        public decimal UA { get; set; }

        public override Answer Execute(BankAppService service)
        {
            service.SetCurrency(US,EU,UA);
            return new OkAnswer();
        }
    }
}
