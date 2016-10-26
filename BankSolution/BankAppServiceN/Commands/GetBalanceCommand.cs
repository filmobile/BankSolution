using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;

namespace BankAppServiceNS.Commands
{
    [Serializable]
    public class GetBalanceCommand : Command
    {
        public string AccountId { get; set; }

        public override Answer Execute(BankAppService service)
        {
            var bal = service.GetBalance(AccountId);
            return new BalanceAnswer { Balans = bal };
        }
    }

    [Serializable]
    public class BalanceAnswer : Answer
    {
        public decimal Balans { get; set; }
    }
}
