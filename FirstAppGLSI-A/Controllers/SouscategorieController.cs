using FirstAppGLSI_A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Controllers
{
    public class SouscategorieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SouscategorieController(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {
            return View(_db.souscategories.Include(c=>c.categorie).ToList());
        }
    }
}
