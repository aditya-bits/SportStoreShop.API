using AutoMapper;
using SportStore.Service.ProductApi.Entities;
using SportStore.Service.ProductApi.Models;

namespace SportStore.Service.ProductApi.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
