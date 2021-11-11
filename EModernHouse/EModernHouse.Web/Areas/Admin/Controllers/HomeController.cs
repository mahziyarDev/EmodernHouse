using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Site;
using LazZiya.ImageResize.Exceptions;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region Ctor

        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly ISiteService _siteService;

        public HomeController(IUserService userService, IProductService productService, ISiteService siteService)
        {
            _userService = userService;
            _productService = productService;
            _siteService = siteService;
        }
        
        #endregion

        public async Task<IActionResult> Index()
        {
            ViewBag.userCount = await _userService.GetUserCount();
            ViewBag.productCount = await _productService.GetProductCount();
            return View();
        }

        #region SiteSetting
        [HttpGet("site-setting")]
        public async Task<IActionResult> SiteSetting(int pageId=1,int take=5)
        {
            var siteSettingFillter =await  _siteService.GetSiteSetting(pageId, take);
            ViewBag.pageId = pageId;
            return View(siteSettingFillter);
        }

        [HttpGet("create-site-setting")]
        public IActionResult CreateSiteSetting()
        {
            return View();
        }

        [HttpPost("create-site-setting")]
        public async Task<IActionResult> CreateSiteSetting(CreateSiteSettingDTO create,IFormFile logoImage)
        {
            if (ModelState.IsValid)
            {
                if (logoImage != null && logoImage.IsImage())
                {
                    var newImage = Guid.NewGuid().ToString("N") + Path.GetExtension(logoImage.FileName);
                    logoImage.AddImageToServer(newImage,PathExtensions.SiteLogoForSave,null,null,null);

                    var res = await _siteService.CreateSetting(create,newImage);
                    if (res)
                    {
                        TempData[SuccessMessage] = "تنظیمات جدید ثبت شد";
                        return RedirectToAction("SiteSetting");
                    }
                }

            }

            TempData[WarningMessage] = "وارد کردن تمامی مقادیر الزامی است";
            return RedirectToAction("CreateSiteSetting");
        }

        [HttpGet("Edit-sie-setting/{settingId}")]
        public async Task<IActionResult> EditSiteSetting(long settingId)
        {
            var edit = await _siteService.GetSiteSettingForEdit(settingId);
            return View(edit);
        }

        [HttpPost("Edit-sie-setting/{settingId}")]
        public async Task<IActionResult> EditSiteSetting(EditSiteSettingDTO edit,IFormFile editLogoImage)
        {
            if (ModelState.IsValid)
            {
                if (editLogoImage != null && editLogoImage.IsImage())
                {
                    var newImage = Guid.NewGuid().ToString("N") + Path.GetExtension(editLogoImage.FileName);
                    editLogoImage.AddImageToServer(newImage,PathExtensions.SiteLogoForSave,null,null,
                        null,edit.LogoImage);
                    edit.LogoImage = newImage;
                }

                var res = await _siteService.SetSiteSettingForEdit(edit);
                if (res)
                {
                    TempData[SuccessMessage] = "ویرایش با موفقیت انجام شد";
                    return RedirectToAction("SiteSetting");
                }
            }

            TempData[SuccessMessage] = "ویرایش به درستی انجام نشد";
            return View(edit);
        }
        [HttpGet("delete-site-setting/{settingId}")]
        public async Task<IActionResult> DeleteSiteSetting(long settingId)
        {
            var res = await _siteService.DeleteSiteSetting(settingId);
            if (res)
            {
                TempData[SuccessMessage] = "حذف شد";
                return RedirectToAction("SiteSetting");
            }

            TempData[ErrorMessage] = "ناموفق در حذف";
            return RedirectToAction("SiteSetting");
        }
        #endregion

        #region
        //[HttpGet("ticket-list")]
        //public async Task<IActionResult> FilterTickets()
        //{
        //    return View();
        //}
        #endregion
    }
}
