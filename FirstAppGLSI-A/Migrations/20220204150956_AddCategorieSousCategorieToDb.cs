using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAppGLSI_A.Migrations
{
    public partial class AddCategorieSousCategorieToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "souscategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_souscategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_souscategories_categorie_categorieId",
                        column: x => x.categorieId,
                        principalTable: "categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                        //onCreate:ReferentialAction.Cascade
                        );
                });

            migrationBuilder.CreateIndex(
                name: "IX_souscategories_categorieId",
                table: "souscategories",
                column: "categorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "souscategories");

            migrationBuilder.DropTable(
                name: "categorie");
        }
    }
}
