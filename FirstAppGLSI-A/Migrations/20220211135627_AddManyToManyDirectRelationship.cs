using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAppGLSI_A.Migrations
{
    public partial class AddManyToManyDirectRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieProduit");
        }
    }
}
