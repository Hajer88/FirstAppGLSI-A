using FirstAppGLSI_A.Models;
using FirstAppGLSI_A.Models.DTO;

namespace FirstAppGLSI_A.Services
{
    public interface ICategorieService
    {
        // récupération de la liste des catégories
        Task<IEnumerable<CategorieDTO>> GetAllCategories();
        //Créer un nouvel enregistrement
        Task<CategorieDTO> CreateNewCat(CategorieDTO cat);
        Task<CategorieDTO> UpdateNewCat(CategorieDTO cat,int id);
        Task<string> DeleteNewCat(int id);
    }
}
