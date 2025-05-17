using e_commerce.Core.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories(int PageIndex , int PageSize)
        {
            var result = await categoriesService.GetCategories(PageIndex, PageSize);
            return Ok(result);
        }
    }
}
