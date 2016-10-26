using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankService;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using BankAppServiceNS.BaseClasses;


namespace BankClient
{
    public class TCPClient
    {
        public int ServerPort { get; set; }
        public string ServerHost { get; set; }

        public Answer SendRequest(Command cmd)
        {
            using (var tcp = new TcpClient(ServerHost, ServerPort))
            {
                new BinaryFormatter().Serialize(tcp.GetStream(), cmd);
                return (Answer)new BinaryFormatter().Deserialize(tcp.GetStream());
            }
        }
    }
}
