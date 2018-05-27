using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Banking.Domain
{
    public class Customer: BaseEntity
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20)]
        public string FirstName { get; protected internal set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        public string LastName { get; protected internal set; }
        [EmailAddress]
        public string Email { get; protected internal set; }
        [Required(ErrorMessage = "Phone is required")]
        [Phone]
        public string Phone { get; protected internal set; }

        public virtual ICollection<Account> Accounts { get; protected internal set; }

        public Customer()
        {

        }
        public Customer(string firstName, string lastName, string email,string phone )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;

        }
    }
}
