using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAppGLSI_A.Migrations
{
    public partial class PopulateProduitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO produits(Name) VALUES('ProduitFromMigrationBuilder')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
