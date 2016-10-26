using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BankAppServiceNS;
using BankService;

namespace BankServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            var service = new BankAppService();
            new Thread(() => server.Start(service)).Start();

            Console.ReadLine();
        }
    }
}
