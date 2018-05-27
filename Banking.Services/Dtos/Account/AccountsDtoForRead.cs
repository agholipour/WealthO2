using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Dtos
{
    public class AccountsDtoForRead
    {
        public string Name { get;  set; }
        public string Number { get;set; }
        public decimal Balance { get;  set; }
        public ICollection<TransactionHistoriesForRead> Transactions { get; set; }

    }
}
