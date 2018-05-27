using AutoMapper;
using Banking.Domain;
using Banking.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Banking.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DateTimeOffset,string>().ConvertUsing(new DateTimeOffsetTypeConverter());

            CreateMap<Account,AccountsDtoForRead>();
            CreateMap<Customer,CustomersDtoForRead>();
            CreateMap<Transaction, TransactionHistoriesForRead>();
        }

 
    }
    public class DateTimeOffsetTypeConverter : ITypeConverter<DateTimeOffset,string>
    {
        
        public string Convert(DateTimeOffset source, string destination, ResolutionContext context)
        {
            return System.Convert.ToString(source.ToString("G"));
        }
    }

   
}
