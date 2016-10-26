using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.Commands;

namespace BankAppServiceNS.BaseClasses
{
    [Serializable]
    public abstract class Command
    {
        public abstract Answer Execute(BankAppService service);
    }
}
