using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        private IAccountRepository _AccountRepository;

        private ICustomerRepository _CustomerRepository;

        private ITransactionRepository _TransactionRepository;

        public IAccountRepository AccountRepository
        {
            get
            {
                return _AccountRepository = _AccountRepository ?? new AccountRepository(_context);
            }
        }
        public ICustomerRepository CustomerRepository
        {
            get
            {
                return _CustomerRepository = _CustomerRepository ?? new CustomerRepository(_context);
            }
        }
        public ITransactionRepository TransactionRepository
        {
            get
            {
                return _TransactionRepository = _TransactionRepository ?? new TransactionRepository(_context);
            }
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
