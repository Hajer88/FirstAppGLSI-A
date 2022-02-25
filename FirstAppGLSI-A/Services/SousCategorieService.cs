using FirstAppGLSI_A.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Services
{
    public class SousCategorieService : ISousCategorieService
    {
        private readonly ApplicationDbContext _db;
        public SousCategorieService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<IEnumerable<SousCategorie>> getSsCatByCatName(string name)
        {
            var sscat = await _db.souscategories
                .Where(c => c.categorie.Name == name)
                .OrderBy(c=>c.Name)
                .ToListAsync();
            return sscat;
        }

        public async Task<SousCategorie> getSsCatById(int id)
        {
            var sscat = await _db.souscategories
                .FirstAsync(c=>c.Id==id);
            return sscat;
        }
    }
}
