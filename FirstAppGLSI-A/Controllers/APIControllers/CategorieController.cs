using FirstAppGLSI_A.Models;
using FirstAppGLSI_A.Models.DTO;
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
        [HttpPost]
        public async Task<IActionResult> AddNewCat(CategorieDTO c)
        {
            var cat = await categorieService.CreateNewCat(c);
            return Ok(c);
        }
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> EditCat(CategorieDTO c, int id)
        {
            var cat = await categorieService.UpdateNewCat(c,id);
            return Ok(c);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCat(int id)
        {
            var cat = await categorieService.DeleteNewCat(id);
            return Ok(cat);
        }
    }
}
