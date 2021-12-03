using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class InventoryController : AdminBaseController
    {
        #region Ctor
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        #endregion

        #region ForInventory

        [HttpGet("inventory")]
        public async Task<IActionResult> FilterForInventory(int pageId = 1, int take = 30, string productName = "")
        {
            var filterProduct = await _inventoryService.GetProducyForInventory(pageId, take, productName);
            ViewBag.pageId = pageId;
            ViewBag.ProducrName = productName;
            return View(filterProduct);
        }

        [HttpGet("inventory/{productId}")]
        public async Task<IActionResult> ShowProductById(long productId)
        {
            var colors = await _inventoryService.ProductColors(productId);
            return View(colors);
        }

        [HttpPost("insert-number-count")]
        public async Task<IActionResult> InsertNumberCount(long colorId, int count)
        {
            var res = await _inventoryService.InsertNumberCount(colorId, count);
            if (res)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }

        #endregion

        #region For-Popular-products
        [HttpGet("get-popular-product")]
        public async Task<IActionResult> GetProductForIndexFilter(int pageId=1,int take=20)
        {
            var res = await _inventoryService.GetPopularProducts(pageId, take);
            ViewBag.PageId = pageId;

            return View(res);
        }

        [HttpGet("DeletePopular/{id}")]
        public async Task<IActionResult> DeletePopular(long id)
        {
            var res = await _inventoryService.DeletePopular(id);
            if (res)
            {
                TempData[SuccessMessage] = "موفقیت امیز بود";
                return RedirectToAction("GetProductForIndexFilter");
            }

            TempData[WarningMessage] = "عملیات ناموفق بود";
            return RedirectToAction("GetProductForIndexFilter");
        }

        [HttpGet("add-popular-product")]
        public async Task<IActionResult> AddProductPopular()
        {
            return View();
        }
        [HttpPost("add-popular-product")]
        public async Task<IActionResult> AddProductPopular(ProductForShowIndex popular)
        {
            var res = await _inventoryService.AddPopularProduct(popular);
            if(res)
            {
                TempData[SuccessMessage] = "موفقیت آمیز بود";
                return RedirectToAction("GetProductForIndexFilter");
            }
            return RedirectToAction("GetProductForIndexFilter");
        }
        #endregion
        
    }
}
