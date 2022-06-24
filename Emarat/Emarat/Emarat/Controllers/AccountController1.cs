using AutoMapper;
using Emarat.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Controllers
{
    public class AccountController1 : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        

        public AccountController1(UserManager <IdentityUser> userManager , SignInManager <IdentityUser> signInManager )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
           
        }
        #region Registration
        [Authorize]
        public IActionResult Registration()
        {
            return View();
        }
        [Authorize]

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser()
                    {
                        Email = model.Email,
                        UserName = model.UserName

                    };
                  var result = await  userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("LogIn");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }


                }
                return View();
            }
            catch (Exception ex)
            {

                return View();
            }

        }
        #endregion
        #region LogIn
        [Authorize]

        public IActionResult LogIn()
        {
            return View();
        }
        [Authorize]

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);
                    if (user != null)
                    {
                       var result = await signInManager.PasswordSignInAsync(user, model.Password, model.IsSelected, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or Password In Correct");
                            return View(model);
                        }
                    }
                }
                return View();
            }
            catch (Exception ex)
            {

                return View();
            }

        }

        #endregion
        #region LogOff
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> LogOff()
        {
          await signInManager.SignOutAsync();
            return RedirectToAction("LogIn");

        }
        #endregion
        #region ForgetPassword
        [Authorize]

        public IActionResult ForgetPassword()
        {
            return View();
        }
        [Authorize]

        [HttpPost]
        public async Task<IActionResult>  ForgetPassword(ForgetPasswordVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {
                        var token = await userManager.GeneratePasswordResetTokenAsync(user);

                        var passwordResetLink = Url.Action("ResetPassword", "Account", new { Email = model.Email, Token = token }, Request.Scheme);

                        

                        

                        return RedirectToAction("ConfirmForgetPassword");
                    }

                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {

                return View();
            }

        }
        [Authorize]

        public IActionResult ConfirmForgetPassword()
        {
            return View();

        }
        #endregion
        #region ResetPassword
        [Authorize]

        public IActionResult ResetPassword(string Email, string Token)
        {
            if (Email!=null && Token !=null)
            {
                return View();
            }
            return RedirectToAction("Registration");
        }
        [Authorize]

        [HttpPost]
        public async Task<IActionResult>  ResetPassword(ResetPasswordVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {
                        var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);

                        if (result.Succeeded)
                        {
                            return RedirectToAction("ConfirmResetPassword");
                        }

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        return View(model);
                    }

                    return RedirectToAction("ConfirmResetPassword");
                }
                return View(model);

            }
            catch (Exception ex)
            {

                return View();
            }

        }
        [Authorize]

        public IActionResult ConfirmResetPassword()
        {
            return View();

        }
        #endregion
    }
}
