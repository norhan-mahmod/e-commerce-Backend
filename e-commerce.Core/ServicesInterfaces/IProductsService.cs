﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Dtos;
using e_commerce.Core.Dtos.ProductsDtos;

namespace e_commerce.Core.ServicesInterfaces
{
    public interface IProductsService
    {
        Task<ResponseDto<List<ProductDto>>> GetAllProducts(GetProductsParametersDto Parameters);
    }
}
