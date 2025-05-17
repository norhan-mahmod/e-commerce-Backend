using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.Dtos.ProductsDtos
{
    public class GetProductsParametersDto
    {
        public int PageIndex {  get; set; }
        public int PageSize { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
    }
}
