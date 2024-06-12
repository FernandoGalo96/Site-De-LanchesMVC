using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LANCHESMVC.Migrations
{
    public partial class corrigindoFotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Lanches SET DescricaoCurta = 'Pão de Hambúrguer, 2 Hambúrguer, Ovo, Bacon, Salada, Salsicha', " +
                           "DescricaoDetalhada = 'Delicioso x tudao', " +
                           "ImagemUrl = 'https://nreceitas.com/wp-content/uploads/2022/12/receita-de-x-tudo.jpg', " +
                           "ImagemThumbNailUrl = 'https://nreceitas.com/wp-content/uploads/2022/12/receita-de-x-tudo.jpg', " +
                           "Preco = 20 WHERE Nome = 'X TUDO'");

            migrationBuilder.Sql("UPDATE Lanches SET DescricaoCurta = 'Pão francês, Carne de Churrasco, Ovo, Salada', " +
                "DescricaoDetalhada = 'Delicioso lanche de bacon', " +
                "ImagemUrl = 'https://imagens.jotaja.com/produtos/c8562901-bb50-47ca-b812-0c0917459257.jpg', " +
                "ImagemThumbNailUrl = 'https://loja.barracadoze.com.br/wp-content/uploads/sites/5/2020/10/x-churrasco.jpg', " +
                "Preco = 22 WHERE Nome = 'X Churrasco'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
