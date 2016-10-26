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
    public class GetClientAccountCommand : Command
    {
        public string UserLogin { get; set; }

        public override Answer Execute(BankAppService service)
        {
            var acc = service.GetClientAccounts(UserLogin);
            return new ClientAccountAnswer { Accounts = acc };
        }
    }

    [Serializable]
    public class ClientAccountAnswer : Answer
    {
        public List<AccountDTO> Accounts { get; set; }
    }

    [Serializable]
    public class AccountDTO
    {
        public AccountDTO(Account acc)
        {
            Balance = acc.Balance;
            Id = acc.Id;
            Currency = acc.Currency;
        }

        public string Id { get; set; }
        public Currency Currency { get; set; }
        public decimal Balance { get; set; }
    }
}
