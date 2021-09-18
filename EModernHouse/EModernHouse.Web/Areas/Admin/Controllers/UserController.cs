using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
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
        public async Task<IActionResult> ListUsers()
        {
            var users = await _userService.GetAllUserForAdmin();
            return View(users);
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
    }
}
