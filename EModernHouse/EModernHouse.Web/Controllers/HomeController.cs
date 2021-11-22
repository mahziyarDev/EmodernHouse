using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.Entities.Site;
using EModernHouse.Web.PresentationExtentions;
using GoogleReCaptcha.V3.Interface;


namespace EModernHouse.Web.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region Ctor

        private readonly IContactService _contactService;
        private readonly ICaptchaValidator _captchaValidator;
        private readonly ISiteService _siteService;
        private readonly IProductService _productService;

        public HomeController(IContactService contactService, ICaptchaValidator captchaValidator, ISiteService siteService, IProductService productService)
        {
            _contactService = contactService;
            _captchaValidator = captchaValidator;
            _siteService = siteService;
            _productService = productService;
        }
        #endregion

        #region Index

        public async Task<IActionResult> Index()
        {
            ViewBag.Banner = await _siteService.GetSiteBannersByPlacement(new List<BannerPlacement>
            {
                BannerPlacement.Home_1,
                BannerPlacement.Home_2,
                BannerPlacement.Home_3, 
                BannerPlacement.Home_4,
                BannerPlacement.Home_5
            });
            
            return View(await _productService.GetProductForIndex(20));
        }
        [HttpGet("banner-test")]
        public async Task<IActionResult> Test()
        {
             EmailSender.SendEmail("mahziyar138006@gmail.com", "تست", "تست");
            
            return View();
        }
        #endregion

        #region ContactUS

        [HttpGet("contact-us")]
        public async Task<IActionResult> ContactUs()
        {
            return View();
        }
        [HttpPost("contact-us")]
        public async Task<IActionResult> ContactUs(CreateContactUsDTO contact)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(contact.Captcha))
            {
                TempData[ErrorMessage] = "کد کپچا شما تایید نشد";
                return View(contact);
            }

            if (ModelState.IsValid)
            {
                var ip = HttpContext.GetUserIp();
                await _contactService.CreateContactUs(contact, HttpContext.GetUserIp(), User.GetUserId());
                TempData[SuccessMessage] = "پیام شما با موفقیت ارسال شد";
                return RedirectToAction("ContactUs");

            }

            return View(contact);
        }

        #endregion

        #region FollowUpProduct

        public IActionResult FollowUp()
        {
            return View();
        }

        #endregion

        #region seller

        public IActionResult Seller()
        {
            return View();
        }

        #endregion


        public async Task<IActionResult> Error404()
        {
            return View();
        }
    }
}
