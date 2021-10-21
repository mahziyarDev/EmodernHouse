using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.PresentationExtentions;
using Microsoft.CodeAnalysis.Differencing;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region Ctor

        private readonly IProductService _productService;
        private readonly IUserService _userService;

        public HomeController(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }

        #endregion

        #region Address

        public async Task<IActionResult> Index()
        {
            ViewData["userAddress"] = await _userService.UserAddressIsYesOrNo(User.GetUserId());
            if (await _userService.UserAddressIsYesOrNo(User.GetUserId()))
            {
                ViewBag.UserInformation = await _userService.GetAddress(User.GetUserId());
            }
            return View();
        }

        [HttpPost("create-address")]
        public async Task<IActionResult> CreateUserAddress(string address)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (string.IsNullOrEmpty(address))
                {
                    TempData[WarningMessage] = "لطفا آدرس خود را وارد نمایید";
                    return RedirectToAction("Index");
                }

                var res = await _userService.InsertUserAddress(User.GetUserId() ,address);
                if (res)
                {
                    TempData[SuccessMessage] = "آدرس شما با موفقیت ثبت شد";
                    return RedirectToAction("Index");
                }

                
            }
            TempData[ErrorMessage] = "عملیات با شکست مواجه شد";
            return RedirectToAction("Index");
        }

        [HttpPost("edit-address")]
        public async Task<IActionResult> EditAddress(string address)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!string.IsNullOrEmpty(address))
                {
                    var res = await _userService.EditAddress(User.GetUserId(), address);
                    if (res)
                    {
                        TempData[SuccessMessage] = "ویرایش با موفقیت انجام شد";
                        return RedirectToAction("Index");
                    }
                }
            }

            TempData[WarningMessage] = "عملیات انجام نشد";
            return RedirectToAction("Index");
        }

        #endregion



        [HttpGet("active-email")]
        public async Task<IActionResult> ActiveEmail()
        {
            return View();
        }

        #region favorite

        [HttpGet("favorite-product")]
        public async Task<IActionResult> FavoriteProduct()
        {
            var favorite = await _productService.GetAllProductInterest(User.GetUserId());
            return View(favorite);
        }

        #endregion
    }
}
