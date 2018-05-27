using AutoMapper;
using Banking.Services.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;


namespace Banking.Services.Controllers
{
    public class BaseApiController :  Controller
    {
        protected readonly IUnitOfWork UnitOfWork = null;
        protected readonly IMapper Mapper;
       

        protected internal BaseApiController()
        {

        }

        public BaseApiController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.UnitOfWork = unitOfWork;
            this.Mapper = mapper;
            
        }
    }
}
