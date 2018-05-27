using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Dtos
{
    public class CustomersDtoForRead
    {
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }

        public ICollection<AccountsDtoForRead> Accounts { get; set; }

    }
}
