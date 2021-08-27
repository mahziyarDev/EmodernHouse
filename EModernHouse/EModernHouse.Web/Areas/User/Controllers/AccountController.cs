using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.Web.PresentationExtentions;
using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class AccountController : UserBaseController
    {
        #region Ctor

        private readonly IUserService _userService;
        private readonly ICaptchaValidator _captchaValidator;

        public AccountController(IUserService userService, ICaptchaValidator captchaValidator)
        {
            _userService = userService;
            _captchaValidator = captchaValidator;
        }

        #endregion

        #region ChangePassword
        [HttpGet("change-password")]
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO passwordDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _userService.ChangeUserPassword(passwordDto, User.GetUserId());

                switch (res)
                {
                    case ChangePasswordResult.Repetition:
                        TempData[WarningMessage] = "رمز قعلی و رمز جدید شما نباید یکسان باشد";
                        break;
                    case ChangePasswordResult.Error:
                        TempData[ErrorMessage] = "رمز فعلی شما درست نیست";
                        break;
                    case ChangePasswordResult.Success:
                        TempData[SuccessMessage] = "کلمه ی عبور شما تغییر یافت";
                        await HttpContext.SignOutAsync();
                        TempData[InfoMessage] = "لطفا جهت تکمیل فرایند تغییر کلمه ی عبور ، مجددا وارد سایت شوید";
                        return RedirectToAction("Login", "Account", new { area = "" });

                }


            }

            return View(passwordDto);
        }
        #endregion

        #region Edit Profile

        [HttpGet("edit-profile")]
        public async Task<IActionResult> EditProfile()
        {
            var userProfile = await _userService.GetProfileForEdit(User.GetUserId());
            if (userProfile == null)
            {
                return NotFound();
            }
            return View(userProfile);
        }

        [HttpPost("edit-profile"), ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(EditUserProfileDTO profile, IFormFile avatarImage)
        {
            if (ModelState.IsValid)
            {
                var res = await _userService.EditUserProfile(profile, User.GetUserId());
                switch (res)
                {
                    case EditUserProfileResult.NotFound:
                        TempData[ErrorMessage] = "کاربری با مشخصات وارد شده یافت نشد";
                        break;
                    case EditUserProfileResult.IsNotActive:
                        TempData[WarningMessage] = "حساب کاربری شما فعال نشده است";
                        break;
                    case EditUserProfileResult.IsBlocked:
                        TempData[ErrorMessage] = "حساب کاربری شما بلاک شده است ";
                        break;
                    case EditUserProfileResult.Success:
                        TempData[SuccessMessage] = $"جناب {profile.FirstName} {profile.LastName} اطلاعات شما با موفقیت ویرایش شد";
                        break;
                        
                }
            }
            return View(profile);
        }

        #endregion
    }
}
