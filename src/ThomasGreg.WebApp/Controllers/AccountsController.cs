using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ThomasGreg.Domain.Models;
using ThomasGreg.WebApp.ViewsModel;

namespace ThomasGreg.WebApp.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountsController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var userExists = await _userManager.FindByEmailAsync(registerViewModel.Email);

                if (userExists != null)
                    this.ModelState.AddModelError("Registro", "Este e-mail já está sendo utilizado");

                var userName = GenerateUsername(registerViewModel.FirstName, 
                    registerViewModel.LastName);

                userExists = await _userManager.FindByEmailAsync(userName);

                if (userExists != null)
                    this.ModelState.AddModelError("Registro", "Este nome já está sendo utilizado");

                var customName = $"{registerViewModel.FirstName} {registerViewModel.LastName}";

                var user = new User
                {
                    UserName = userName,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    CustomName = customName,
                    Email = registerViewModel.Email
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Login", "Account");
                }
                else
                {

                    this.ModelState.AddModelError("Registro", "Falha ao registrar o usuário");
                }
            }
            return View(registerViewModel);
        }

        public string GenerateUsername(string firstName, string lastName)
        {
          
            DateTime now = DateTime.Now;
            string uniqueUsername = $"{firstName}{lastName}{now:yyyyMMddHHmmss}";

            return uniqueUsername;
        }



        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
       
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginViewModel)
        {
            if (!ModelState.IsValid)
                return View(LoginViewModel);

            var userExists = await _userManager.FindByEmailAsync(LoginViewModel.Email);

            if (userExists != null)
            {
                var result = await _signInManager.PasswordSignInAsync(userExists,
                    LoginViewModel.Password, false, false);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Falha ao realizar o login!!");
            return View(LoginViewModel);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }


}
