using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppServiceNS.BaseClasses
{
    [Serializable]
    public class ErrorAnswer : Answer
    {
        public string Message { get; set; }
    }
}
