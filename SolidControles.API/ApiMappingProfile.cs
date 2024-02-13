using AutoMapper;
using Solid.Api.Models;
using Solid.Core.Entities;

namespace Solid.Api
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Customer, CustomerPostModel>().ReverseMap();
            CreateMap<SaleAndRenting, SaleAndRentingPostModel>().ReverseMap();
            CreateMap<Transactions,TransactionPostModel>().ReverseMap();
        }
    }
}
