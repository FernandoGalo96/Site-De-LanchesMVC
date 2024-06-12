using LANCHESMVC.Context;
using Microsoft.EntityFrameworkCore;

namespace LANCHESMVC.Models;

public class CarrinhoCompra
{
    private readonly AppDbContext _context;

    public CarrinhoCompra(AppDbContext context)
    {
        _context = context;
    }

    public string CarrinhoCompraId { get; set; } 

    public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    public static CarrinhoCompra GetCarrinho(IServiceProvider services)
    {
        ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

        var context = services.GetRequiredService<AppDbContext>();
        
        string carrinhoId = session.GetString("CarrinhoId")?? Guid .NewGuid().ToString();

        session.SetString("CarrinhoId", carrinhoId);

        return new CarrinhoCompra(context)
        {
            CarrinhoCompraId = carrinhoId

        };

    }

    public void AdicionarAoCarrinho (Lanche id)
    {
        var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault( l => l.Lanche.LancheId == id.LancheId &&
        l.CarrinhoCompraId == CarrinhoCompraId); 

        if(carrinhoCompraItem == null )
        {
            var carrinhoCompraI = new CarrinhoCompraItem
            {
                CarrinhoCompraId = CarrinhoCompraId,
                Lanche = id,
                Quantidade = 1
            };
            _context.CarrinhoCompraItens.Add(carrinhoCompraI);

        }else
        {
            carrinhoCompraItem.Quantidade++;
        }

        _context.SaveChanges();
    }

    public int RemoverDoCarrinho (Lanche id )
    {
       var carrinhoCompraI = _context.CarrinhoCompraItens.SingleOrDefault(c => c.Lanche.LancheId == id.LancheId &&
        c.CarrinhoCompraId == CarrinhoCompraId);

        var quantidadeLocal = 0;

        if (carrinhoCompraI != null)
        {
            if (carrinhoCompraI.Quantidade > 1)
            {
                carrinhoCompraI.Quantidade--;
                quantidadeLocal = carrinhoCompraI.Quantidade;

            } else
            {
               _context.CarrinhoCompraItens.Remove(carrinhoCompraI);
            }
            _context.SaveChanges();
            return quantidadeLocal;
       
        }
        return 0;

    }

    public List<CarrinhoCompraItem> GetCarrinhoCompraItems  ()
    {
        return CarrinhoCompraItems ?? (CarrinhoCompraItems =
            _context.CarrinhoCompraItens.Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
            .Include(s => s.Lanche)
            .ToList());
    }

    public void LimparCarrinho ()
    {
        var carrinhoItens = _context.CarrinhoCompraItens.Where(c => c.CarrinhoCompraId == CarrinhoCompraId);
        _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);
        _context.SaveChanges();

    }

    public decimal GetCarrinhoCompraTotal ()
    {
        var total = _context.CarrinhoCompraItens.Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
            .Select(c => c.Lanche.Preco * c.Quantidade).Sum();

        return total;


    }
}
 