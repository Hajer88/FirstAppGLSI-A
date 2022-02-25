using AutoMapper;
using FirstAppGLSI_A.Models;
using FirstAppGLSI_A.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _imapper;
        public CategorieService(ApplicationDbContext _db, IMapper _imapper)
        {
            this._db = _db;
            this._imapper = _imapper;
        }

        public async Task<CategorieDTO> CreateNewCat(CategorieDTO cat)
        {
            var cc = _imapper.Map<Categorie>(cat);
            _db.categorie.Add(cc);
            await _db.SaveChangesAsync();
            return cat;
        }

        public async Task<string> DeleteNewCat(int id)
        {
            var cat = await _db.categorie.FindAsync(id);
            _db.categorie.Remove(cat);
            await _db.SaveChangesAsync();
            return "Contenu supprimé";
        }

        public async Task<IEnumerable<CategorieDTO>> GetAllCategories()
        {
            var cat = await _db.categorie
                .Include(c=>c.sousCategories)
                .Include(p=>p.produits)
                //.Where()
                .ToListAsync();
            //var categories = from c in _db.categorie
            //                 select new CategorieDTO()
            //                 {
            //                     Id=c.Id,
            //                     Name = c.Name,
            //                 };
            //var ca = categories.ToList();
            return _imapper.Map<List<CategorieDTO>>(cat);
        }

        public async Task<CategorieDTO> UpdateNewCat(CategorieDTO cat, int id)
        {
            var catInDb = await _db.categorie.FindAsync(id);
            //AutoMapper
            catInDb.Name = cat.Name;
            await _db.SaveChangesAsync();

            return _imapper.Map<Categorie,CategorieDTO>(catInDb);
        }
    }
}
