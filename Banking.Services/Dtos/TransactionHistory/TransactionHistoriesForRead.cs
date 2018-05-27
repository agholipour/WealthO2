using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Dtos
{
    public class TransactionHistoriesForRead
    {
        public decimal Value { get;  set; }
        public string Date { get;  set; }
        public TransactionTypes TransactionType { get;  set; }
    }
}
