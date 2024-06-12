Descrição do Projeto
Este projeto é uma aplicação ASP.NET Core MVC com diversas funcionalidades implementadas para ilustrar boas práticas no desenvolvimento de software, incluindo o uso de Entity Framework Core, migrações, repositórios, injeção de dependência e muito mais.

Tecnologias Utilizadas
ASP.NET Core MVC
Entity Framework Core
SQL Server
Bootstrap
Funcionalidades Implementadas
Conexão com Banco de Dados
Utilização do Entity Framework Core para gerenciar a conexão com o SQL Server.
Configuração e uso de migrações para criar e popular as tabelas do banco de dados.
Estrutura do Projeto
Implementação de repositórios para acessar e manipular dados do banco de forma abstrata.
Aplicação de injeção de dependência para gerenciar a criação e o ciclo de vida dos objetos.
Relacionamentos de Classes
Classe Categoria com relacionamento 1
com a classe Lanche.
ViewModels e Views
Uso correto de ViewModels para transferir dados entre o controller e a view.
Implementação de partial views para componentes reutilizáveis na interface.
Funcionalidades do Carrinho de Compras
Implementação completa do carrinho de compras utilizando sessions.
Criação do CarrinhoCompraController e da CarrinhoCompraViewModel.
Implementação de um ViewComponent para exibir o resumo do carrinho de compras.
Botões para adicionar itens ao carrinho diretamente da view de detalhes e da view de resumo.
TagHelpers e Componentes
Criação de uma TagHelper para enviar e-mails.
Implementação de ViewComponents para exibir lanches por categoria.
Funcionalidades de Pesquisa
Criação de um método Search no LancheController e sua exibição no layout para permitir a pesquisa de lanches por nome.
Gerenciamento de Pedidos
Criação das classes Pedido e PedidoDetalhe com relacionamento 1
.
Adição das classes ao contexto e geração de migrações.
Criação do PedidoRepository com método CriarPedido.
Configuração da injeção de dependência para PedidoRepository no Program.cs.
Implementação do PedidoController e suas views para processar pedidos dos clientes.
Sistema de Autenticação
Implementação do Identity para autenticação e autorização.
Configuração do Identity no Program.cs e geração de migrações para o banco de dados.
Criação do AccountController com os métodos login, register e logout.
Adição das views correspondentes e da _LoginPartial para exibir o estado de autenticação no layout.
Este projeto demonstra a integração de diversas tecnologias e padrões de projeto para criar uma aplicação web robusta e escalável. É um excelente exemplo de como aplicar as melhores práticas de desenvolvimento em um projeto real.


