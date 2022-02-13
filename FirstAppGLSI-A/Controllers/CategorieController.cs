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
           
                _db.categorie.Add(categorie);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            
        }
        public IActionResult Edit(int? id)
        {
            if(id==null) { return NotFound(); }
            var cat = _db.categorie.Find(id);
            var cat2 = _db.categorie.First(c => c.Id == id);
            return View(cat);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categorie cat)
        {
            _db.categorie.Update(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) { return NotFound(); }
            var cat = _db.categorie.Find(id);
            var cat2 = _db.categorie.First(c => c.Id == id);
            return View(cat);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            var cat = _db.categorie.Find(id);
            _db.categorie.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

