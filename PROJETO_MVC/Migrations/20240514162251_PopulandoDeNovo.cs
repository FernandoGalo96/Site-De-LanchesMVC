using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LANCHESMVC.Migrations
{
    public partial class PopulandoDeNovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbNailUrl, IsLanchePreferido, Nome, Preco) " +
               "VALUES(2, 'Pão integral, Patinho, Ovo, Salada', 'uma delicia pra você que esta na dieta', 2, " +
               "'https://specialepaes.com/wp-content/uploads/2021/10/blog-speciale-receita.png', " +
               "'https://img.freepik.com/fotos-gratis/sanduiche_1339-1108.jpg', 1, 'X MAROMBA', 12)");

            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbNailUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão de Hamburguer, Hamburguer, Ovo, Bacon, Salada', 'delicioso lanche de bacon', 1, " +
                "'https://pubimg.band.uol.com.br/files/d1165981419e682cd534.png', " +
                "'https://static.ifood-static.com.br/image/upload/t_medium/pratos/4320aa7e-db55-471c-995a-f42949218dec/202004201849_yoaM_.jpeg', 0, 'X BACONZITO', 15)");

            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbNailUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(2, 'Pão de Hamburguer, 2 Hamburguer, Ovo, Bacon, Salada, Salsicha', 'delicioso x tudao', 1, " +
                "'https://nreceitas.com/wp-content/uploads/2022/12/receita-de-x-tudo.jpg', " +
                "'https://loja.barracadoze.com.br/wp-content/uploads/sites/5/2020/10/x-churrasco.jpg', 0, 'X TUDO', 20)");

            migrationBuilder.Sql("INSERT INTO Lanches(IdCategoria, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemUrl, ImagemThumbNailUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão frances, Carne de Churrasco, Ovo, Salada', 'delicioso lanche de bacon', 1, " +
                "'https://imagens.jotaja.com/produtos/c8562901-bb50-47ca-b812-0c0917459257.jpg', " +
                "'https://loja.barracadoze.com.br/wp-content/uploads/sites/5/2020/10/x-churrasco.jpg', 0, 'X Churrasco', 22)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}