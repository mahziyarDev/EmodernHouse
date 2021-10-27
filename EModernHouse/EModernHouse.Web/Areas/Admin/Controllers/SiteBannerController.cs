using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Site;
using EModernHouse.DataLayer.Entities.Site;
using Microsoft.AspNetCore.Http;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class SiteBannerController : AdminBaseController
    {
        #region Ctor

        private readonly ISiteService _siteService;

        public SiteBannerController(ISiteService siteService)
        {
            _siteService = siteService;
        }

        #endregion
        [HttpGet("site-banner")]
        public async Task<IActionResult> Index()
        {
            var siteBanners = await _siteService.GetSiteBanner();
            return View(siteBanners);
        }

        [HttpGet("create-banner")]
        public async Task<IActionResult> CreateBanner()
        {
            return View();
        }
        
        [HttpPost("create-banner")]
        public async Task<IActionResult> CreateBanner(SiteBannerDTO banner,IFormFile bannerImage)
        {
            if (bannerImage != null )
            {
                if (ModelState.IsValid)
                {
                    var newImage = Guid.NewGuid().ToString("N") + Path.GetExtension(bannerImage.FileName);
                    var imagePath = PathExtensions.BannerOriginServer + newImage;

                    await using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await bannerImage.CopyToAsync(stream);
                    }
                    banner.ImageName = newImage;
                    var res = await _siteService.CreateSiteBanner(banner);
                    if (res)
                    {
                        TempData[SuccessMessage] = "بنر با موفقیت اضافه شد";
                        return RedirectToAction("Index");
                    }

                }
                
            }
            TempData[ErrorMessage] = "مقادیر به درستی وارد نشده سات";
            return View(banner);
        }

        [HttpGet("delete-banner/{bannerId}")]
        public async Task<IActionResult> DeleteBanner(long bannerId)
        {
            var res = await _siteService.DeleteSiteBanner(bannerId);
            if (res)
            {
                TempData[SuccessMessage] = "باموفقیت حذف شد";
                return RedirectToAction("Index");
            }

            TempData[ErrorMessage] = "عملیات شکست خورد";
            return RedirectToAction("Index");
        }

        [HttpGet("edit-sitebBanner/{bannerId}")]
        public async Task<IActionResult> EDitBanner(long bannerId)
        {
            var editBanner = await _siteService.EditBanner(bannerId);
            return View(editBanner);
        }
        [HttpPost("edit-sitebBanner/{bannerId}")]
        public async Task<IActionResult> EDitBanner(EditSiteBannerDTO edit,IFormFile bannerImage)
        {
            if (ModelState.IsValid)
            {
                if (bannerImage != null)
                {
                    var newImage = Guid.NewGuid().ToString("N") + Path.GetExtension(bannerImage.FileName);
                    var imagePath = PathExtensions.BannerOriginServer + newImage;
                    var deletePath = PathExtensions.BannerOriginServer + edit.ImageName;
                    if (System.IO.File.Exists(deletePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    await using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await bannerImage.CopyToAsync(stream);
                    }
                    
                    edit.ImageName = newImage;
                }

                var res = await _siteService.EditBannerSet(edit);
                if (res)
                {
                    TempData[SuccessMessage] = "ویرایش با موفقیت انجام شد";
                    return RedirectToAction("Index");
                }
            }

            TempData[ErrorMessage] = "عملیات موفقیت امیز نبود";
            return RedirectToAction("Index");
        }

    }
}
