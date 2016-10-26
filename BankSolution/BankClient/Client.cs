using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;
using BankAppServiceNS.Commands;
using BankClient.Properties;

namespace BankClient
{
  public static  class Client
    {
        public static string UserLoginIn { get; set; }

        public static Answer Execute(Command cmd)
        {
            var client = new TCPClient() { ServerHost = Settings.Default.ListenIp, ServerPort = Settings.Default.ListenPort };
            var answer = client.SendRequest(cmd);
            if (answer is ErrorAnswer)
                throw new Exception((answer as ErrorAnswer).Message);
            return answer;
        }
    }
}
