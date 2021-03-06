﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppServiceNS.BaseClasses;
using BankModel;

namespace BankAppServiceNS.Commands
{
    [Serializable]
  public  class GetCancelTransactionCommand:Command
    {
        public string UserLogin { get; set; }
        public override Answer Execute(BankAppService service)
        {
            var tr = service.GetCancelTransaction(UserLogin);
            return new CancelTransactionAnswer { CancelTransactions = tr };
        }
    }

    [Serializable]
    public class CancelTransactionAnswer : Answer
    {
        public List<CancelTransactionDTO> CancelTransactions { get; set; }
    }

    [Serializable]
    public class CancelTransactionDTO
    {
        public CancelTransactionDTO(Transaction trans)
        {
            FromAccId = trans.From.Id;
            ToAccId = trans.To.Id;
            SumAcc = trans.Summa;

        }
        public string FromAccId { get; set; }
        public string ToAccId { get; set; }
        public decimal SumAcc { get; set; }

        public override string ToString()
        {
            return string.Format("AccFrom {0}, AccTo: {1}, Summa {2:0.00}", FromAccId, ToAccId, SumAcc);
        }
    }
}
