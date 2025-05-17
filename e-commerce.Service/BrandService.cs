using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.BrandsDtos;
using e_commerce.Core.Entities;
using e_commerce.Core.RepositoriesInterfaces;
using e_commerce.Core.ServicesInterfaces;
using e_commerce.Core.SpecificationPattern;
using e_commerce.Service.Helpers;

namespace e_commerce.Service
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BrandService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ResponseDto<List<BrandDto>>> GetAllBrands(int PageIndex , int PageSize)
        {
            try
            {
                // For Getting Total Count for MetaData
                var allBrandsCount = await unitOfWork.Repository<Brand>().GetCountAsync();

                var spec = new Specification<Brand>();
                spec.ApplyPagination(PageIndex, PageSize);
                var brands = await unitOfWork.Repository<Brand>().GetAllWithSpecAsync(spec);
                var brandsDto = mapper.Map<List<BrandDto>>(brands);
                var response = ResponseBuilder<Brand>.BuildResponseWithMetaData(brandsDto, allBrandsCount, PageIndex, PageSize);
                return response;
            }
            catch(Exception ex)
            {
                return new ResponseDto<List<BrandDto>>() { Message = ex.InnerException.Message };
            }
        }
    }
}
