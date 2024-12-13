using GameStoreMVC.Models;
using GameStoreMVC.ViewModels.Auths;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreMVC.Controllers;

public class AccountController(UserManager<User> _userManager, SignInManager<User> _singinManager) : Controller
{
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterVM vm)
    {
        if (!ModelState.IsValid) return View();
        User user = new User
        {
            FullName = vm.FirstName,
            UserName = vm.UserName,
            Email = vm.EmailAddress,
        };
        var result = await _userManager.CreateAsync(user, vm.Password);
        if (!result.Succeeded)
        {
            foreach (var err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }
        }
        if (!ModelState.IsValid) return View();
        return RedirectToAction(nameof(Login));
    }
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginVM vm)
    {
        if (!ModelState.IsValid) return View();
        User? user = null;
        if (vm.EmailorUser.Contains("@"))
            await _userManager.FindByEmailAsync(vm.EmailorUser);
        else
            await _userManager.FindByEmailAsync(vm.EmailorUser);
        if (user is null)
        {
            ModelState.AddModelError("", "User Don`t exist");
            return View();
        }
        var result = await _singinManager.PasswordSignInAsync(user, vm.Password, vm.RememberMe, true);
        return View();
    }
}
