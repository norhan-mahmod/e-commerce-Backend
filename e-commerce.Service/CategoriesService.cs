using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.CategoriesDtos;
using e_commerce.Core.Entities;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Core.ServicesInterfaces;
using e_commerce.Core.SpecificationPattern;
using e_commerce.Service.Helpers;

namespace e_commerce.Service
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoriesService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ResponseDto<List<CategoryDto>>> GetCategories(int PageIndex, int PageSize)
        {
            try
            {
                var allCategoriesCount = await unitOfWork.Repository<Category>().GetCountAsync();

                var spec = new Specification<Category>();
                spec.ApplyPagination(PageIndex, PageSize);
                var categories = await unitOfWork.Repository<Category>().GetAllWithSpecAsync(spec);
                var categoriesDto = mapper.Map<List<CategoryDto>>(categories);
                var response = ResponseBuilder<Category>.BuildResponseWithMetaData(categoriesDto, allCategoriesCount, PageIndex, PageSize);
                return response;
            }
            catch(Exception ex)
            {
                return new ResponseDto<List<CategoryDto>>() { Message = ex.InnerException.Message };
            }
        }
    }
}
