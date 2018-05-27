using System;
using System.ComponentModel.DataAnnotations;

namespace Banking.Domain
{
    public class Transaction: BaseEntity
    {
        [Range(0.01, double.MaxValue, ErrorMessage = "Transaction value cannot be Zero or Negative.")]
        public decimal Value { get; protected internal set; }
        public DateTimeOffset Date { get; protected internal set; }
        public TransactionTypes TransactionType { get; protected internal set; }
        public Guid AccountId { get; protected internal set; }
        public virtual Account Account { get; protected internal set; }
        public Transaction()
        {
                
        }
        public Transaction(decimal value,DateTimeOffset date,TransactionTypes transactionType, Guid accountId )
        {
            this.AccountId = accountId;
            this.Date = date;
            this.Value = value;
            this.TransactionType = transactionType;

        }
    }
}
