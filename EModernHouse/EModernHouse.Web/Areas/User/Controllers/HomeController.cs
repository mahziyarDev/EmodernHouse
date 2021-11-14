using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Comment;
using EModernHouse.Web.PresentationExtentions;
using Microsoft.CodeAnalysis.Differencing;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region Ctor

        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly IContactService _contactService;
        public HomeController(IProductService productService, IUserService userService, IContactService contactService)
        {
            _productService = productService;
            _userService = userService;
            _contactService = contactService;
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

        #region Comment
        [HttpPost("create_comment")]
        public async Task<IActionResult> CreateCommetn(CreateCommentDTO comment)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    var res =await _contactService.CreateComment(comment, User.GetUserId());
                    if (res)
                    {
                        TempData[InfoMessage] = "کامنت شما درحال برسی است و پس از تایید در سایت منتشر میشود";
                    }

                    return RedirectToAction("product-Detail/" + comment.ProductId);
                }

                TempData[WarningMessage] = "اطلاعات به درستی وارد نشده است";
                return RedirectToAction("product-Detail/" + comment.ProductId);
            }
            TempData[ErrorMessage] = "برای ثبت نظر ابتدا باید وارد سایت شوید";
            return RedirectToAction("product-Detail/" + comment.ProductId);
        }

        #endregion
    }
}
