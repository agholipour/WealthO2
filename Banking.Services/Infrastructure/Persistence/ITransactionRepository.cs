﻿using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Infrastructure.Persistence
{
   public interface ITransactionRepository
    {
        Transaction FindById(Guid Id);
        IEnumerable<Transaction> List();
    }
}
