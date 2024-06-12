using LANCHESMVC.Context;
using LANCHESMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LANCHESMVC.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signinManager;

    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
    {
        _userManager = userManager;
        _signinManager = signinManager;
    }


    public IActionResult Login (string returnUrl)
    {

        return View(new LoginViewModel ()

        { 
            ReturnUrl = returnUrl

        });
    }

    [HttpPost]

    public async Task<IActionResult> Login (LoginViewModel loginVM)
    {
        if (!ModelState.IsValid)
            return View(loginVM);

        //Localizando o usuário pelo nome

        var user = await _userManager.FindByNameAsync(loginVM.UserName);

        if (user != null)
        {
            var result = await _signinManager.PasswordSignInAsync(user, loginVM.Password, false, false);
            if (result.Succeeded)
            {
                if(string.IsNullOrEmpty(loginVM.ReturnUrl))
                {
                    return RedirectToAction("Index","Home");
                }

                return Redirect(loginVM.ReturnUrl);
            }
        }
        ModelState.AddModelError("", "Falha ao realizar o login");
        return View(loginVM);
    }

    public IActionResult Register ()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> Register (LoginViewModel loginVM)
    {
        if (ModelState.IsValid)
        {
           var user = new IdentityUser { UserName = loginVM.UserName };
            var result = await  _userManager.CreateAsync(user, loginVM.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                this.ModelState.AddModelError("Registro","Falha ao registrar o usuário");
            }
        }
        return View(loginVM);
             
            
    }

    [HttpPost]

    public async Task<IActionResult> Logout ()
    {
        HttpContext.Session.Clear();
        HttpContext.User = null;
        await _signinManager.SignOutAsync();
        return RedirectToAction("Index", "Home");

    }

}
