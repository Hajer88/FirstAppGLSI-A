using AutoMapper;
using FirstAppGLSI_A.Models.DTO;

namespace FirstAppGLSI_A.Models
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Categorie, CategorieDTO>();
            CreateMap<CategorieDTO, Categorie>();
        }
    }
}
