using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;

namespace EModernHouse.Web.Controllers
{
    public class AccountController : Controller
    {
        #region Cotr

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
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
            if (ModelState.IsValid)
            {
                var res =await _userService.RegisterUSer(register);
                switch (res)
                {
                    case RegisterUserResult.MobilExists:
                        TempData["ErrorMessage"] = "تلفن همراه وارد شده تکراری می باشد";
                        ModelState.AddModelError("Mobile", "تلفن همراه وارد شده تکراری می باشد");
                        break;
                    case RegisterUserResult.Success:
                        TempData["SuccessMessage"] = "ثبت نام شما با موفقیت انجام شده است";
                        TempData["InfoMessage"] = "کد تایید تلفن همراه برای شما ارسال شد";
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

        #endregion
    }
}
