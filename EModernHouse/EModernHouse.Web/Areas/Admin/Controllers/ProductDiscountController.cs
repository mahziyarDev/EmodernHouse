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

        [HttpGet("create-product-discount")]
        public async Task<IActionResult> CreateProductDiscount()
        {
            return View();
        }

        [HttpPost("create-product-discount"),ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProductDiscount(CreateProductDiscountDTO discount)
        {
            if (ModelState.IsValid)
            {
                var res = await _productDiscountService.CreateProductDiscount(discount);
                if (res)
                {
                    TempData[SuccessMessage] = "تخفیف جدید با موفقیت اضافه شد";
                    return RedirectToAction("GetDiscount");
                }
            }

            TempData[ErrorMessage] = "اطلاعات وارد شده کافی یا معتبر نمی باشد";
            return View(discount);
        }

        //[HttpGet("delete-discount")]
        //public async Task<bool> DeleteProductDiscount()}
    }
}
