using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;

namespace BankAppServiceNS.Commands
{
    [Serializable]
    public class SignUpCommand : Command
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public override Answer Execute(BankAppService service)
        {
            service.SignUp(UserLogin, UserPassword);
            return new OkAnswer();
        }
    }
}
