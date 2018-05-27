using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banking.Services.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/customers/{customerId}/accounts")]
    public class AccountsController : BaseApiController
    {
        public AccountsController(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {

        }
    }
}