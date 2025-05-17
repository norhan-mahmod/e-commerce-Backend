using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.BrandsDtos;

namespace e_commerce.Core.ServicesInterfaces
{
    public interface IBrandService
    {
        Task<ResponseDto<List<BrandDto>>> GetAllBrands(int PageIndex, int PageSize);
    }
}
