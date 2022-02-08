using FirstAppGLSI_A.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppGLSI_A.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategorieController(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {
            return View(_db.categorie.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categorie categorie)
        {
            if (ModelState.IsValid)
            {
                _db.categorie.Add(categorie);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(categorie);
        }
    }
}
