using FirstAppGLSI_A.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppGLSI_A.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private ICategorieService categorieService;
        public CategorieController(ICategorieService categorieService)
        {
            this.categorieService = categorieService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesContr()
        {
            var cat = await categorieService.GetAllCategories();
            return Ok(cat);
        }
    }
}
