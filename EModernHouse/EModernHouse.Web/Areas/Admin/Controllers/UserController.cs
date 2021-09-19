using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.Web.Http;
using Microsoft.CodeAnalysis.Differencing;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        #region Ctor

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region List-user

        [HttpGet("user-list")]
        public async Task<IActionResult> ListUsers(int pageId=1,int take=5,string mobile="",string name="",string email="")
        {
            var usersFilter = await _userService.GetUsersForFilter(pageId, take, mobile, name, email);
            ViewBag.pageId = pageId;
            ViewBag.name = name;
            ViewBag.mobile = mobile;
            ViewBag.email = email;
            ViewBag.take = take;
            return View(usersFilter);
        }

        #endregion

        #region Create User
        [HttpGet("create-user")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost("create-user"),ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(CreateUserDTO create)
        {
            if (ModelState.IsValid)
            {
                var res = await _userService.CreateUser(create);
                if (res)
                {
                    TempData[SuccessMessage] = "افزودن با موفقیت انجام شد";
                    return RedirectToAction("ListUsers");
                }
            }
            return View(create);
        }

        #endregion

        #region Edit User
        [HttpGet("edit-for-admin/{userId}")]
        public async Task<IActionResult> EdtiUserForAdmin(long userId)
        {
            var user = await _userService.GetUserForEdit(userId);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost("edit-for-admin/{userId}")]
        public async Task<IActionResult> EdtiUserForAdmin(EditUserDTO edit, long userId)
        {
            if (ModelState.IsValid)
            {
                var res = await _userService.SetUserForEdit(edit,userId);
               
                    TempData[SuccessMessage] = "ویرایش باموفقیت انجام شد";
                    return RedirectToAction("ListUsers");
                
            }

            return View(edit);
        }
        #endregion

        #region IsdeletedUser

        [HttpGet("delete-user/{userId}")]
        public async Task<IActionResult> IsDeletedUser(long userId)
        {

            var result = await _userService.IsDeletedUser(userId);

            if (result)
            {
                return JsonResponseStatus.SendStatus(
                    JsonResponseStatusType.Success,
                    "درخواست مورد نظر با موفقیت تایید شد",
                    null
                );
            }

            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "اطلاعاتی با این مشخصات یافت نشد",
                null);
        }

        #endregion

        #region IsBlockedUser
        [HttpGet("block-user/{userId}")]
        public async Task<IActionResult> IsBlockedUser(long userId)
        {
            var result = await _userService.IsBlocked(userId);

            if (result)
            {
                return JsonResponseStatus.SendStatus(
                    JsonResponseStatusType.Success,
                    "درخواست مورد نظر با موفقیت تایید شد",
                    null
                );
            }

            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "اطلاعاتی با این مشخصات یافت نشد",
                null);
        }

        #endregion
    }
}
