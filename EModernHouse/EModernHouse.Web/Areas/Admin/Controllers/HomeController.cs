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

        public HomeController(IUserService userService, IProductService productService)
        {
            _userService = userService;
            _productService = productService;
        }
        
        #endregion
        public async Task<IActionResult> Index()
        {
            ViewBag.userCount = await _userService.GetUserCount();
            ViewBag.productCount = await _productService.GetProductCount();
            return View();
        }
    }
}
