using e_commerce.Core.Dtos.ProductsDtos;
using e_commerce.Core.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts([FromQuery]GetProductsParametersDto Parameters)
        {
            var result = await productsService.GetAllProducts(Parameters);
            return Ok(result);
        }
    }
}
