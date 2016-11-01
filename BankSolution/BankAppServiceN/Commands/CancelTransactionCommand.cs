using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;

namespace BankAppServiceNS.Commands
{
    [Serializable]
   public class CancelTransactionCommand:Command
    {
        public decimal Sum { get; set; }
        public string FromAccountId { get; set; }
        public string ToAccountId { get; set; }

        public override Answer Execute(BankAppService service)
        {
            service.CancelTransacton(FromAccountId,ToAccountId,Sum);
            return new OkAnswer();
        }
    }
}
