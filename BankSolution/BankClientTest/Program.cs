using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using BankAppServiceNS.BaseClasses;
using BankAppServiceNS.Commands;
using BankModel;



namespace BankClientTest
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


    class Program
    {
        static void Main(string[] args)
        {

            var client = new TCPClient { ServerHost = "127.0.0.1", ServerPort = 32456 };
            var cmd1 = new SignUpCommand() { UserLogin = "Test", UserPassword = "1111" };
            var answer1 = client.SendRequest(cmd1);
            if (answer1 is OkAnswer)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Registration is fail");

            var cmd2 = new SignUpCommand() { UserLogin = "Hello", UserPassword = "111" };
            var answer2 = client.SendRequest(cmd2);
            if (answer2 is OkAnswer)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Registration is fail");

            var cmd3 = new LoginCommand() { UserLogin = "Test", UserPassword = "1111" };
            var answer3 = client.SendRequest(cmd3);

            if (answer3 is OkAnswer)
                Console.WriteLine("OK You are in Database ");
            else
                Console.WriteLine("Registration is fail");

            var cmd4 = new CreateAccountCommand() { UserLogin = "Test", Currency = Currency.UA };
            var answer4 = client.SendRequest(cmd4);
            if (answer4 is OkAnswer)
                Console.WriteLine("Ok");
            else
                Console.WriteLine(" Is fail");

            var cmd9 = new CreateAccountCommand() { UserLogin = "Test", Currency = Currency.US };
            var answer9 = client.SendRequest(cmd9);
            if (answer9 is OkAnswer)
                Console.WriteLine("Ok Second acc");
            else
                Console.WriteLine(" Is fail");

            var cmd5 = new GetBalanceCommand() { AccountId = "1" };
            var answer5 = client.SendRequest(cmd5);
            if (answer5 is BalanceAnswer)

                Console.WriteLine((answer5 as BalanceAnswer).Balans);
            else
                Console.WriteLine(" Is fail");
            var cmd6 = new CreateFirstTransactionsCommand() { Sum = 100, AccountId = "1" };
            var answer6 = client.SendRequest(cmd6);
            if (answer6 is OkAnswer)
                Console.WriteLine("Ok");
            else
                Console.WriteLine(" Is fail");

            var cmd7 = new GetBalanceCommand() { AccountId = "1" };
            var answer7 = client.SendRequest(cmd7);
            if (answer7 is BalanceAnswer)

                Console.WriteLine((answer7 as BalanceAnswer).Balans);
            else
                Console.WriteLine(" Is fail");

            var cmd8 = new GetClientAccountCommand() { UserLogin = "Test" };
            var answer8 = client.SendRequest(cmd8);
            if (answer8 is ClientAccountAnswer)
                foreach (var p in (answer8 as ClientAccountAnswer).Accounts)
                    Console.WriteLine(p.Balance);
            else
                Console.WriteLine("Fail");

            var cmd10 = new CreateTransactionCommand() { FromAccountId = "1", ToAccountId = "2", Sum = 50 };
            var answer10 = client.SendRequest(cmd10);
            if (answer10 is OkAnswer)
                Console.WriteLine("Ok");
            else
                Console.WriteLine(" Is fail");

            var cmd11 = new GetClientAccountCommand() { UserLogin = "Test" };
            var answer11 = client.SendRequest(cmd11);
            if (answer11 is ClientAccountAnswer)
                foreach (var p in (answer11 as ClientAccountAnswer).Accounts)
                    Console.WriteLine(p.Id);
            else
                Console.WriteLine("Fail");


            Console.ReadLine();

        }
    }
}
