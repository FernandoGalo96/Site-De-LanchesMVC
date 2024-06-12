using LANCHESMVC.Models;
using LANCHESMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LANCHESMVC.Components;

public class CarrinhoCompraResumo : ViewComponent
{
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
    {
        _carrinhoCompra = carrinhoCompra;
    }

    public IViewComponentResult Invoke ()
    {
        var item = _carrinhoCompra.GetCarrinhoCompraItems();
        //var item = new List<CarrinhoCompraItem>
        //{
        //    new CarrinhoCompraItem(),
        //    new CarrinhoCompraItem()
        //};

        _carrinhoCompra.CarrinhoCompraItems = item;

        var carrinhoCompraViewModel = new CarrinhoCompraViewModel
        {
            CarrinhoCompra = _carrinhoCompra,
            CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
        };

        return View(carrinhoCompraViewModel);
    }
}
