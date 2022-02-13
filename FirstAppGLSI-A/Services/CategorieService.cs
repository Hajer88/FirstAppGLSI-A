using FirstAppGLSI_A.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ApplicationDbContext _db;
        public CategorieService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<IEnumerable<Categorie>> GetAllCategories()
        {
            var cat = await _db.categorie.ToListAsync();
            return cat;
        }
    }
}
