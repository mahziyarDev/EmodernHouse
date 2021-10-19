using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.PresentationExtentions;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region Ctor

        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion
        public IActionResult Index()
        {
            return View();
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
    }
}
