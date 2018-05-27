using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banking.Services.Dtos;
using Banking.Services.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/customers")]
    public class CustomersController : BaseApiController
    {
        public CustomersController(IUnitOfWork unitOfWork, IMapper mapper)
           : base(unitOfWork, mapper)
        {

        }

        [HttpGet()]
        public IActionResult GetCustomers()
        {
            var customers = this.UnitOfWork.CustomerRepository.List();
            var results = Mapper.Map<IEnumerable<CustomersDtoForRead>>(customers);

            return Ok(results);
        }

        [HttpGet("{customerId}")]
        public IActionResult GetCustomerByID(Guid customerId)
        {
            var customer = this.UnitOfWork.CustomerRepository.FindById(customerId);
            var results = Mapper.Map<CustomersDtoForRead>(customer);

            return Ok(results);
        }
    }
}