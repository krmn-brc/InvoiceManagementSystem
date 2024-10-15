
using Entities.Models.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{

    public class AccountController : Controller
    {


        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromForm] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser? appUser = await _userManager.FindByNameAsync(loginModel.UserNameOrEmail);
                if (appUser == null)
                    appUser = await _userManager.FindByEmailAsync(loginModel.UserNameOrEmail);
                if (appUser != null)
                {
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(appUser, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect("Home/Index");
                    }
                }
                ModelState.AddModelError("Error", "Invalid user name or password");
            }
            return View();
        }


    }
}