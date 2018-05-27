using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Infrastructure.Persistence
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Account FindById(Guid Id)
        {
            var result = _context.Accounts
                  .SingleOrDefault(x => x.Id == Id);
            return result;
        }

        public IEnumerable<Account> List()
        {
            var result = _context.Accounts
                .ToList();

            return result;
        }
    }
}
