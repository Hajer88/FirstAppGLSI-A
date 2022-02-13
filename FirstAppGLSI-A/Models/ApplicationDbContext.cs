using Microsoft.EntityFrameworkCore;

namespace FirstAppGLSI_A.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Produit> produits { get; set; }
        public DbSet<Categorie> categorie { get; set; }
        public DbSet<SousCategorie> souscategories { get; set; }
        public DbSet<CategorieProduit> categorieProduits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategorieProduit>()
                .HasKey(t => new { t.ProduitId, t.CategorieId });
            modelBuilder.Entity<CategorieProduit>()
                .HasOne(x => x.categorie)
                .WithMany(y => y.produits)
                .HasForeignKey(x => x.CategorieId);
            modelBuilder.Entity<CategorieProduit>()
                .HasOne(x => x.produit)
                .WithMany(y => y.categories)
                .HasForeignKey(x => x.ProduitId);
        }
    }
}
