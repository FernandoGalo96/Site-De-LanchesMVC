using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LANCHESMVC.Migrations
{
    public partial class corrigindo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoriaNome",
                table: "Categorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaNome",
                table: "Categorias");
        }
    }
}