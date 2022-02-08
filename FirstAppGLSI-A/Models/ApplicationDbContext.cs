using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public DbSet<Produit> produits { get; set; }
        public DbSet<Categorie> categorie { get; set; }
        public DbSet<SousCategorie> souscategories { get; set; }
    }
}
