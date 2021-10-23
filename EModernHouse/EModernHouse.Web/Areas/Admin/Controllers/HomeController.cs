using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;

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
        #endregion
    }
}
