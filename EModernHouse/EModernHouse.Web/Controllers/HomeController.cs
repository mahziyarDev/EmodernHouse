using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Site;
using EModernHouse.Web.PresentationExtentions;
using Ganss.XSS;
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
        private readonly IUserService _userService;
        private readonly IPaymentService _paymentService;

        public HomeController(IContactService contactService, ICaptchaValidator captchaValidator, ISiteService siteService, IProductService productService, IUserService userService, IPaymentService paymentService)
        {
            _contactService = contactService;
            _captchaValidator = captchaValidator;
            _siteService = siteService;
            _productService = productService;
            _userService = userService;
            _paymentService = paymentService;
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


            //string redirectUrl = "";
            //var result = _paymentService.CreatePaymentRequest(
            //    null,
            //    100000,
            //    "توضیحات",
            //    "http://localhost:54500/contact-us",
            //    ref redirectUrl,
            //    "test@test.com",
            //    "09913439792"
            //);

            //if (result == PaymentStatus.St100)
            //{
            //    return Redirect(redirectUrl);
            //}

            var tupleProducts = await _productService.GetProductForIndex(20);
            return View(tupleProducts);
        }

        [HttpGet("banner-test")]
        public async Task<IActionResult> Test()
        {
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
                var sanitizer = new HtmlSanitizer();
                contact.Mobile = sanitizer.Sanitize(contact.Mobile);
                contact.Email = sanitizer.Sanitize(contact.Email);
                contact.FullName = sanitizer.Sanitize(contact.FullName);
                contact.Subject = sanitizer.Sanitize(contact.Subject);
                contact.Text = sanitizer.Sanitize(contact.Text);
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
