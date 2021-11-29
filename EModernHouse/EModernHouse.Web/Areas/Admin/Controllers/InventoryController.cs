using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;

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
        public async Task<IActionResult> InsertNumberCount(long colorId,int count)
        {
             var res = await _inventoryService.InsertNumberCount(colorId, count);
            if (res)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
    }
}
