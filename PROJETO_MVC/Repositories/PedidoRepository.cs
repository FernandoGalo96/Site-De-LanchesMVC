using LANCHESMVC.Context;
using LANCHESMVC.Models;
using LANCHESMVC.Repositories.Interfaces;

namespace LANCHESMVC.Repositories;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;
    private readonly CarrinhoCompra _carrinhoCompra;

    public PedidoRepository(AppDbContext context, CarrinhoCompra carrinhoCompra)
    {
        _context = context;
        _carrinhoCompra = carrinhoCompra;
    }

    public void CriarPedido(Pedido pedido)
    {
        pedido.PedidoEnviado = DateTime.Now;
        _context.Add(pedido);
        _context.SaveChanges();

        var carrinhoPedidos = _carrinhoCompra.GetCarrinhoCompraItems();

        foreach (var carrinho in  carrinhoPedidos)
        {
            var pedidoDetail = new PedidoDetalhe()
            {
                Quantidade = carrinho.Quantidade,
                LancheId = carrinho.Lanche.LancheId,
                PedidoId = pedido.PedidoId,
                Preco = carrinho.Lanche.Preco

            };

            _context.PedidoDetalhes.Add(pedidoDetail);
        }

        _context.SaveChanges();
    }
}
