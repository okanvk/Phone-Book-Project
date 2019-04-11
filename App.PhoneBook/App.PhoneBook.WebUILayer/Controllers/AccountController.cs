using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.PhoneBook.WebUILayer.IdentityEntities;
using App.PhoneBook.WebUILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.PhoneBook.WebUILayer.Controllers
{

    public class AccountController : Controller
    {

        private SignInManager<CustomIdentityUser> signInManager;

        public AccountController(SignInManager<CustomIdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public ActionResult Login()
        {
            TempData.Add("no-cat", "message");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = signInManager.PasswordSignInAsync(loginViewModel.UserName,
                    loginViewModel.Password, loginViewModel.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }

                ModelState.AddModelError("CustomError", "Invalid login!");
            }

            return View(loginViewModel);
        }
       
    }
}