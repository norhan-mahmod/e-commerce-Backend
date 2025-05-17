using AutoMapper;
using e_commerce.Core.Dtos.BrandsDtos;
using e_commerce.Core.Dtos.CategoriesDtos;
using e_commerce.Core.Dtos.ProductsDtos;
using e_commerce.Core.Entities;

namespace e_commerce.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(productDto => productDto.ProductImages,
                    o => o.MapFrom(product => product.ProductImages.Select(image => image.ImageUrl)))
                .ForMember(productDto => productDto.BrandName, o => o.MapFrom(product => product.Brand.Name))
                .ForMember(productDto => productDto.CategoryName, o => o.MapFrom(product => product.Category.Name));
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
