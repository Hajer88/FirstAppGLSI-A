namespace FirstAppGLSI_A.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SousCategorie> sousCategories { get; set; }
        public ICollection<CategorieProduit> produits { get; set; }
    }
}
