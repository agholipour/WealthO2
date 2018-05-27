using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banking.Domain
{
    
   public class Account : BaseEntity
    {
        [StringLength(50)]
        [Required(ErrorMessage = "Account Name is required")]
        public string Name { get; protected internal set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Account Number is required")]
        public string Number { get; protected internal set; }
        public decimal Balance { get; protected internal set; }
        public Guid CustomerId { get; protected internal set; }


        public virtual Customer Customer { get; protected internal set; }

        public virtual ICollection<Transaction> Transactions { get; protected internal set; }

        public Account()
        {

        }
        public Account(string name, string number, decimal balance, Guid customerId)
        {
            this.Balance = balance;
            this.CustomerId = customerId;
            this.Name = name;
            this.Number = number;
        }
    }
}
