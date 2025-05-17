using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.ProductsDtos;
using e_commerce.Core.Entities;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Core.ServicesInterfaces;
using e_commerce.Core.SpecificationPattern;
using e_commerce.Service.Helpers;

namespace e_commerce.Service
{
    public class ProductsService : IProductsService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ResponseDto<List<ProductDto>>> GetAllProducts(GetProductsParametersDto Parameters) 
        {
            try
            {
                Specification<Product> spec ;

                // For Filtering by brand or Category
                if (Parameters.BrandId.HasValue)
                    spec = new Specification<Product>(product => product.BrandId == Parameters.BrandId);
                else if (Parameters.CategoryId.HasValue)
                    spec = new Specification<Product>(product => product.CategoryId == Parameters.CategoryId);
                else
                    spec = new Specification<Product>();

                // For Getting Total Count for MetaData
                var allProducts = await unitOfWork.Repository<Product>().GetAllWithSpecAsync(spec);

                spec.AddInclude(product => product.Brand);
                spec.AddInclude(product => product.Category);
                spec.AddInclude(product => product.ProductImages);
                spec.ApplyPagination(Parameters.PageIndex, Parameters.PageSize);
                var products = await unitOfWork.Repository<Product>().GetAllWithSpecAsync(spec);
                var productsDto = mapper.Map<List<ProductDto>>(products);
                var response = ResponseBuilder<List<ProductDto>>.BuildResponseWithMetaData(productsDto, allProducts.Count, Parameters.PageIndex, Parameters.PageSize);
                return response;
            }
            catch (Exception ex)
            {
                return new ResponseDto<List<ProductDto>>() { Message = ex.InnerException.Message };
            }
        }
    }
}
