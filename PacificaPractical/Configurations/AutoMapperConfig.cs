using AutoMapper;
using PacificaPractical.DBModels;
using PacificaPractical.DTOs;


namespace SchoolAdminPortalReactApp.Server.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Seller, SellerDTO>().ReverseMap();
            CreateMap<IEnumerable<Seller>, IEnumerable<SellerDTO>>().ReverseMap();
            CreateMap<IEnumerable<Product>, IEnumerable<ProductDTO>>().ReverseMap();
            CreateMap<List<Product>, List<ProductDTO>>().ReverseMap();

        }
    }
}
