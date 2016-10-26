using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;
using BankModel;

namespace BankAppServiceNS.Commands
{
    [Serializable]
    public class CreateAccountCommand : Command
    {
        public string UserLogin { get; set; }
        public Currency Currency { get; set; }

        public override Answer Execute(BankAppService service)
        {
            service.CreateAccount(UserLogin, Currency);
            return new OkAnswer();
        }
    }
}
