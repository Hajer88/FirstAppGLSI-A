using System.ComponentModel.DataAnnotations;

namespace FirstAppGLSI_A.Models
{
    public class SousCategorie
    {
        public int Id { get; set; }
        [Display(Name ="Sous Categorie Name")]
        public string Name { get; set; }
        public Categorie categorie { get; set; }
    }
}
