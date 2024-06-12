using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LANCHESMVC.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbNailUrl, IsLanchePreferido, Nome, Preco) " +
     "VALUES(1, 'Pão, Hamburguer, Ovo, Presunto, Queijo', 'Delicioso pão de hamburguer com ovo frito;TUDO no maior capricho', 1, " +
     "'https://p2.trrsf.com/image/fget/cf/942/530/images.terra.com/2022/06/17/1972971289-sanduiche-quente-de-mortadela-46089-768x507.jpg', " +
     "'https://loja.barracadoze.com.br/wp-content/uploads/sites/5/2020/10/x-churrasco.jpg', 0, 'X EGG', 13)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}