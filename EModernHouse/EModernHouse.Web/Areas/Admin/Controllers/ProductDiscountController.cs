using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Product;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class ProductDiscountController : AdminBaseController
    {
        #region Ctor

        private readonly IProductDiscountService _productDiscountService;

        public ProductDiscountController(IProductDiscountService productDiscountService)
        {
            _productDiscountService = productDiscountService;
        }

        #endregion

        [HttpGet("list-discount")]
        public async Task<IActionResult> GetDiscount(int pageId=1,int take=5)
        {
            var discounts = await _productDiscountService.GetDiscount(pageId, take);
            return View(discounts);
        }

        [HttpGet("Filter-Product-For-Discount")]
        public async Task<IActionResult> GetProductForDiscountFilter(string productName)
        {
            var data = await _productDiscountService.FilterProductByName(productName);
            return new JsonResult(data);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductDiscount(CreateProductDiscountDTO discount)
        {
            return View();
        }
    }
}
