namespace FirstAppGLSI_A.Models
{
    public class CategorieProduit
    {
        public int ProduitId { get; set; }
        public int CategorieId { get; set; }
        public Produit produit { get; set; }
        public Categorie categorie { get; set; }
    }
}
