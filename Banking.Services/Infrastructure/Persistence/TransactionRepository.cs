using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Infrastructure.Persistence
{
    public class TransactionRepository: ITransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Transaction FindById(Guid Id)
        {
            var result = _context.Transactions
                 .SingleOrDefault(x => x.Id == Id);
            return result;
        }

        public IEnumerable<Transaction> List()
        {
            var result = _context.Transactions
               .ToList();

            return result;
        }
    }
}
