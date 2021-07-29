using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EModernHouse.Web.Controllers
{
    public class AccountController : SiteBaseController
    {
        #region Cotr

        private readonly IUserService _userService;
        private readonly ICaptchaValidator _captchaValidator;

        public AccountController(IUserService userService, ICaptchaValidator captchaValidator)
        {
            _userService = userService;
            _captchaValidator = captchaValidator;
        }

        #endregion

        #region Register

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDTO register)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(register.Captcha))
            {
                TempData[ErrorMessage] = "کد کپچا شما تایید نشد";
                return View(register);
            } 
            if (ModelState.IsValid)
            {
                var res = await _userService.RegisterUSer(register);
                switch (res)
                {
                    case RegisterUserResult.MobilExists:
                        TempData[ErrorMessage] = "تلفن همراه وارد شده تکراری می باشد";
                        ModelState.AddModelError("Mobile", "تلفن همراه وارد شده تکراری می باشد");
                        break;
                    case RegisterUserResult.Success:
                        TempData[SuccessMessage] = "ثبت نام شما با موفقیت انجام شده است";
                        TempData[InfoMessage] = "کد تایید تلفن همراه برای شما ارسال شد";
                        return RedirectToAction("Login");
                }
            }
            return View(register);
        }
        #endregion

        #region Login

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login"),ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserDTO login)  
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(login.Captcha))
            {
                TempData[ErrorMessage] = "کد کپچا شما تایید نشد";
                return View(login);
            }

            if (ModelState.IsValid)
            {
                var res = await _userService.GetUserForLogin(login);
                switch (res)
                {
                    case LoginUserResult.NotFount:
                        TempData[ErrorMessage] = "کاربر مورد نظر یافت نشد";
                        break;
                    case LoginUserResult.NotActivated:
                        TempData[WarningMessage] = "حساب کاربری شما تایید نشده است";
                        break;
                    case LoginUserResult.Success:

                        var user = await _userService.GetUserByMobile(login.Mobile);

                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,user.Mobile),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            
                        };
                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        var properties = new AuthenticationProperties
                        {
                            IsPersistent = login.RememberMe,
                        };

                        await HttpContext.SignInAsync(principal, properties);

                        TempData[SuccessMessage] = "ورود با موفقیت انجام شد";
                        return Redirect("/");

                }
            }
            return View(login);
        }
        #endregion

        #region ForgotPassword

        [HttpGet("/forgot-pass")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost("/forgot-pass")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO forgot)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(forgot.Captcha))
            {
                TempData[ErrorMessage] = "کد کپچا شما تایید نشد";
                return View(forgot);
            }

            if (ModelState.IsValid)
            {
                var res = await _userService.RecoverUserPassword(forgot);
                switch (res)
                {
                    case ForgotPasswordResult.NotFount:
                        TempData[ErrorMessage] = "متاسفانه شما با این شماره در این سیستم حسابی ندارید";
                        break;
                    case ForgotPasswordResult.NotActivated:
                        TempData[WarningMessage] = "حساب شما فعال نیست";
                        break;
                    case ForgotPasswordResult.Success:
                        TempData[SuccessMessage] = "پیامی حاوی رمز جدید برای شما ارسال شده در حفظ ان کوشا باشید";
                        TempData[InfoMessage] = "لطفا بعد از ورود سریعا به حساب کاربری خود مراجعه کنید و رمز خود را تغییر دهید";

                        return RedirectToAction("Login");
                }
            }
            return View(forgot);
        }
        #endregion

        #region LogOut

        [HttpGet("log-out")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        #endregion
    }
}
