﻿// <auto-generated />
using FirstAppGLSI_A.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstAppGLSI_A.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FirstAppGLSI_A.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categorie");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.CategorieProduit", b =>
                {
                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.HasKey("ProduitId", "CategorieId");

                    b.HasIndex("CategorieId");

                    b.ToTable("categorieProduits");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("produits");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.SousCategorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categorieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categorieId");

                    b.ToTable("souscategories");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.CategorieProduit", b =>
                {
                    b.HasOne("FirstAppGLSI_A.Models.Categorie", "categorie")
                        .WithMany("produits")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstAppGLSI_A.Models.Produit", "produit")
                        .WithMany("categories")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");

                    b.Navigation("produit");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.SousCategorie", b =>
                {
                    b.HasOne("FirstAppGLSI_A.Models.Categorie", "categorie")
                        .WithMany("sousCategories")
                        .HasForeignKey("categorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorie");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.Categorie", b =>
                {
                    b.Navigation("produits");

                    b.Navigation("sousCategories");
                });

            modelBuilder.Entity("FirstAppGLSI_A.Models.Produit", b =>
                {
                    b.Navigation("categories");
                });
#pragma warning restore 612, 618
        }
    }
}
