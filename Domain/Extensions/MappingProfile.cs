using AutoMapper;
using Domain.Models;

namespace Domain.Extensions
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Product, Infrastructure.Models.Product>();
            CreateMap<Infrastructure.Models.Product, Product>();
        }
    }
}
