using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BankAppServiceNS;

namespace BankService
{
    public partial class BankService : ServiceBase
    {
        public BankService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           // Debugger.Launch();
            var server = new Server();
            var service = new BankAppService();
            new Thread(() => server.Start(service)).Start();
            Thread.Sleep(100);

        }

        protected override void OnStop()
        {
        }
    }
}
