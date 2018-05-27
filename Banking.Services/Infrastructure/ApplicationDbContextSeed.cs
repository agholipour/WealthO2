using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking.Services.Infrastructure
{
    public static class ApplicationDbContextSeed
    {
        public static void EnsureSeedDataForContext(this ApplicationDbContext context)
        {

            AddCustomer(context);

            AddAccount(context);

           Addtransaction(context);

            context.SaveChanges();
        }
        private static void AddCustomer(ApplicationDbContext context)
        {
            var customers = new List<Customer>();
            if (!context.Customers.Any(x => x.FirstName == "George"))
            {
                customers.Add(new Customer("George", " Clooney", "George.Clooney@gamil.com","0450282964"));
            }
            if (!context.Customers.Any(x => x.FirstName == "Tom"))
            {
                customers.Add(new Customer("Tom", "Cruise", "Tom.Cruise@gamil.com", "0450282965"));
            }
            if(customers.Any())
            context.Customers.AddRange(customers);
        }


        private static void AddAccount(ApplicationDbContext context)
        {
            var accounts = new List<Account>();

            if (!context.Accounts.Any(x => x.Name == "George Clooney"))
            {
                accounts.Add(new Account("George Clooney", "08355558",12000000.00m,Guid.Parse("4f83bb9d-1334-4187-b456-08d5c38b149f")));
            }

            if (!context.Accounts.Any(x => x.Name == "Tom Cruise"))
            {
                accounts.Add(new Account("Tom Cruise", "08357779", 12000000.00m, Guid.Parse("54b4da0b-a5f6-45c9-b457-08d5c38b149f")));
            }
            if (accounts.Any())
                context.Accounts.AddRange(accounts);
        }

        private static void Addtransaction(ApplicationDbContext context)
        {
            var transactions  = new List<Transaction>();

            if (!context.Transactions.Any())
            {
                transactions.Add(new Transaction(100000m,DateTimeOffset.Now,TransactionTypes.Credit,Guid.Parse("786f9425-038d-4091-46e1-08d5c38d0739")));
                transactions.Add(new Transaction(50000m, DateTimeOffset.Now, TransactionTypes.Credit, Guid.Parse("786f9425-038d-4091-46e1-08d5c38d0739")));
                transactions.Add(new Transaction(50000m, DateTimeOffset.Now, TransactionTypes.Debit, Guid.Parse("786f9425-038d-4091-46e1-08d5c38d0739")));
                transactions.Add(new Transaction(100000m, DateTimeOffset.Now, TransactionTypes.Credit, Guid.Parse("786f9425-038d-4091-46e1-08d5c38d0739")));
                transactions.Add(new Transaction(100000m, DateTimeOffset.Now, TransactionTypes.Debit, Guid.Parse("786f9425-038d-4091-46e1-08d5c38d0739")));

                transactions.Add(new Transaction(100000m, DateTimeOffset.Now, TransactionTypes.Credit, Guid.Parse("a13ba792-c41b-4862-46e2-08d5c38d0739")));
                transactions.Add(new Transaction(50000m, DateTimeOffset.Now, TransactionTypes.Debit, Guid.Parse("a13ba792-c41b-4862-46e2-08d5c38d0739")));
                transactions.Add(new Transaction(50000m, DateTimeOffset.Now, TransactionTypes.Credit, Guid.Parse("a13ba792-c41b-4862-46e2-08d5c38d0739")));
                transactions.Add(new Transaction(100000m, DateTimeOffset.Now, TransactionTypes.Debit, Guid.Parse("a13ba792-c41b-4862-46e2-08d5c38d0739")));
                transactions.Add(new Transaction(100000m, DateTimeOffset.Now, TransactionTypes.Credit, Guid.Parse("a13ba792-c41b-4862-46e2-08d5c38d0739")));

            }



            if (transactions.Any())
            context.Transactions.AddRange(transactions);
        }


    }
}
