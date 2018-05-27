﻿using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services.Infrastructure.Persistence
{
    public interface IAccountRepository
    {
        Account FindById(Guid Id);
        IEnumerable<Account> List();
    }
}
