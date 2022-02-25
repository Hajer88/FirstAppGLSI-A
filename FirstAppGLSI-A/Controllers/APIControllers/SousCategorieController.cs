using FirstAppGLSI_A.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppGLSI_A.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SousCategorieController : ControllerBase
    {
        private readonly ISousCategorieService sousCategorieService;
        public SousCategorieController(ISousCategorieService sousCategorieService)
        {
            this.sousCategorieService = sousCategorieService;
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GEtssCatbyCatName(string name)
        {
            var sscat = await sousCategorieService.getSsCatByCatName(name);
            return Ok(sscat);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> getsscatById(int id)
        {
            var sscat = await sousCategorieService.getSsCatById(id);
            return Ok(sscat);
        }
    }
        
}
