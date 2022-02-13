using FirstAppGLSI_A.Models;

namespace FirstAppGLSI_A.Services
{
    public interface ICategorieService
    {
        // récupération de la liste des catégories
        Task<IEnumerable<Categorie>> GetAllCategories();
    }
}
