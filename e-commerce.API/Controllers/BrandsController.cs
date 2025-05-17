using e_commerce.Core.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService brandService;

        public BrandsController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        [HttpGet("GetBrands")]
        public async Task<IActionResult> GetBrands(int PageIndex , int PageSize)
        {
            var result = await brandService.GetAllBrands(PageIndex, PageSize);
            return Ok(result);
        }
    }
}
