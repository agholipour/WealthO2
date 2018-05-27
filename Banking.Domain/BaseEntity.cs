using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Domain
{
    public class BaseEntity
    {
        public Guid Id { get; protected internal set; }
    }
}
