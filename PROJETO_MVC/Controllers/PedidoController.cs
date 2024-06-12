using LANCHESMVC.Models;
using LANCHESMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LANCHESMVC.Controllers;

public class PedidoController : Controller
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
    {
        _pedidoRepository = pedidoRepository;
        _carrinhoCompra = carrinhoCompra;
    }

    [HttpGet]
    public IActionResult Checkout ()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Checkout (Pedido pedido)
    {
        int totalItensPedido = 0;
        decimal precoTotalPedido = 0.0m;

        //obtem os itens do carrinho de compra do cliente
        List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItems();
        _carrinhoCompra.CarrinhoCompraItems = items;

        // verificar se existe itens de pedido

        if (_carrinhoCompra.CarrinhoCompraItems.Count == 0)
        {
            ModelState.AddModelError("","O carrinho está vazio, quer incluir algo?");
        }

        //calcular o total de itens e o total do pedido

        foreach (var item in items)
        {
            totalItensPedido += item.Quantidade;
            precoTotalPedido += (item.Lanche.Preco * item.Quantidade);

        }

        // atribui os valores obtidos ao pedido
        pedido.TotalItensPedido = totalItensPedido;
        pedido.PedidoTotal = precoTotalPedido;

        //validar os dados do pedido

        if (ModelState.IsValid)
        {
            //criar o pedidos e seus detalhes

            _pedidoRepository.CriarPedido(pedido);

            //define mensagens ao cliente

            ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido!";
            ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

            //limpar o carrinho

            _carrinhoCompra.LimparCarrinho();

            //exibe a view com dados do cliente e do pedido

            return View("~/Views/Pedido/CheckoutCompleto.cshtml",pedido);
        }

        return View(pedido);



    }


}
