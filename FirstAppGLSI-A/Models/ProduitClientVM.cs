namespace FirstAppGLSI_A.Models
{
    public class ProduitClientVM
    {
        public Produit produit { get; set; }
        public IEnumerable<Client> clients { get; set; }
    }
}
