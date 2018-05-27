using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Domain;
using Microsoft.EntityFrameworkCore;

namespace Banking.Services.Infrastructure.Persistence
{
    public class CustomerRepository :ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer FindById(Guid Id)
        {
            var result = _context.Customers
                .Include(x=>x.Accounts)
                .ThenInclude(x=>x.Transactions)
                  .SingleOrDefault(x => x.Id == Id);
            return result;
        }

        public IEnumerable<Customer> List()
        {
            var result = _context.Customers
               .ToList();

            return result;
        }
    }
}
