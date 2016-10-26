using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using BankAppServiceNS.Commands;
using BankAppServiceNS.BaseClasses;
using BankAppServiceNS;
using BankService.Properties;

namespace BankService
{
    public class Server
    {
      
        public void Start(BankAppService service)
        {
            var list = new TcpListener(IPAddress.Parse( Settings.Default.ListenIp), Settings.Default.ListenPort);
            list.Start();
            while (true)
                using (var tcp = list.AcceptTcpClient())
                {
                    var cmd = (Command)new BinaryFormatter().Deserialize(tcp.GetStream());
                    try
                    {
                        var answer = cmd.Execute(service);
                        new BinaryFormatter().Serialize(tcp.GetStream(), answer);
                        service.Dispose();
                    }
                    catch (Exception ex)
                    {
                        new BinaryFormatter().Serialize(tcp.GetStream(), new ErrorAnswer() { Message = ex.Message });
                    }
                }

        }
    }

}
