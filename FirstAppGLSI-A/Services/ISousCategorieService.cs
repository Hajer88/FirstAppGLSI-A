using FirstAppGLSI_A.Models;

namespace FirstAppGLSI_A.Services
{
    public interface ISousCategorieService
    {
        Task<IEnumerable<SousCategorie>> getSsCatByCatName(string name);
        //Get Sous Cat By Id
        Task<SousCategorie> getSsCatById(int id);

    }
}
