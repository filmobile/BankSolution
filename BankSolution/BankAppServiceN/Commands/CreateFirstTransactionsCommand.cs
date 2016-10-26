using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;

namespace BankAppServiceNS.Commands
{
    [Serializable]
    public class CreateFirstTransactionsCommand : Command
    {
        public decimal Sum { get; set; }
        public string AccountId { get; set; }

        public override Answer Execute(BankAppService service)
        {
            service.CreateFirstTransaction(Sum, AccountId);
            return new OkAnswer();
        }
    }
}
