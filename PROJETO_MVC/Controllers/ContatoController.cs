using Microsoft.AspNetCore.Mvc;

namespace LANCHESMVC.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
