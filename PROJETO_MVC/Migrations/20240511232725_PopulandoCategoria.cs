using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LANCHESMVC.Migrations
{
    public partial class PopulandoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES " +
                "('Simples','Simples mas feito com muito amor')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES " +
               "('Natural','Lanche feito para você que está em sua fase Fitness')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}