using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.CategoriesDtos;
using e_commerce.Core.Entities;

namespace e_commerce.Core.ServicesInterfaces
{
    public interface ICategoriesService
    {
        Task<ResponseDto<List<CategoryDto>>> GetCategories(int PageIndex, int PageSize);
    }
}
