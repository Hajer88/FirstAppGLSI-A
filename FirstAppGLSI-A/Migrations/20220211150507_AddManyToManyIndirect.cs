using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAppGLSI_A.Migrations
{
    public partial class AddManyToManyIndirect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieProduit");

            migrationBuilder.CreateTable(
                name: "categorieProduits",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorieProduits", x => new { x.ProduitId, x.CategorieId });
                    table.ForeignKey(
                        name: "FK_categorieProduits_categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categorieProduits_produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categorieProduits_CategorieId",
                table: "categorieProduits",
                column: "CategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categorieProduits");

            migrationBuilder.CreateTable(
                name: "CategorieProduit",
                columns: table => new
                {
                    categoriesId = table.Column<int>(type: "int", nullable: false),
                    produitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieProduit", x => new { x.categoriesId, x.produitsId });
                    table.ForeignKey(
                        name: "FK_CategorieProduit_categorie_categoriesId",
                        column: x => x.categoriesId,
                        principalTable: "categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieProduit_produits_produitsId",
                        column: x => x.produitsId,
                        principalTable: "produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieProduit_produitsId",
                table: "CategorieProduit",
                column: "produitsId");
        }
    }
}
