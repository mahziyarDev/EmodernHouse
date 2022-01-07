using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.DTOs.Comment;
using EModernHouse.DataLayer.DTOs.UserPanel;
using EModernHouse.Web.PresentationExtentions;
using Ganss.XSS;
using Microsoft.CodeAnalysis.Differencing;
using WebMarkupMin.Core;

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


        /// <summary>
        /// صفحه اصلی پنل کاربر برای نمایش اطلاعات ادرس و شماره تلفن
        /// </summary>
        /// <returns>return view and view model</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var viewModel = await _userService.IndexUserPanel(User.GetUserId());
            return View(viewModel);
        }

        /// <summary>
        /// برای ثبت و ویرایش ادرس کابر
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns>redirect to action index with tempdata</returns>
        [HttpPost]
        public async Task<IActionResult> Manage(UserPanelIndexDTO viewModel)
        {
            var userId = User.GetUserId();
            var result = await _userService.Manage(userId,viewModel);
            if (result)
                TempData[SuccessMessage] = "با موفقیت ثبت شد";
            else
                TempData[ErrorMessage] = "خطا در ثبت ادرس";

            return RedirectToAction("Index");
        }


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
                    var sanitizer = new HtmlSanitizer();
                    comment.TextComment = sanitizer.Sanitize(comment.TextComment);
                    comment.TitleComment = sanitizer.Sanitize(comment.TitleComment);
                    var res =await _contactService.CreateComment(comment, User.GetUserId());
                    if (res)
                    {
                        TempData[InfoMessage] = "کامنت شما درحال برسی است و پس از تایید در سایت منتشر میشود";
                    }

                    return Redirect("/product-Detail/" + comment.ProductId + "/" + comment.ProductName);
                }

                TempData[WarningMessage] = "اطلاعات به درستی وارد نشده است";
                return Redirect("/product-Detail/" + comment.ProductId + "/" + comment.ProductName);
            }
            TempData[ErrorMessage] = "برای ثبت نظر ابتدا باید وارد سایت شوید";
            return Redirect("/product-Detail/" + comment.ProductId + "/" + comment.ProductName);
        }

        [HttpGet("show-comments")]
        public async Task<IActionResult> ShowComments()
        {
            return View(await _contactService.ShowCommentsForUser(User.GetUserId()));
        }

        [HttpGet("delete-comment/{commentId}")]
        public async Task<IActionResult> DeleteComment(long commentId)
        {
            var res = await _contactService.DeleteComment(User.GetUserId(), commentId);
            if (res)
            {
                TempData[SuccessMessage] = "نظر شما با موفقیت حذف شد";
                return RedirectToAction("ShowComments");
            }
            TempData[WarningMessage] = "چنین نظری برای شما ثبت نشده است ";
            return RedirectToAction("ShowComments");
        }

        #endregion
    }
}
