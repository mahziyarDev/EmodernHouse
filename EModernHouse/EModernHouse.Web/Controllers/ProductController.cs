using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;

namespace EModernHouse.Web.Controllers
{
    public class ProductController : Controller
    {
        #region Ctor

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        #region ProductList
        [HttpGet("product-archive")]
        [HttpGet("product-archive/{category}")]
        public async Task<IActionResult> Products(int pageId=1,int take=20,int startPrice=0,int endPrice=0,long? category=null)
        {
            var model = await _productService.GetProductsForUsers(pageId, take, startPrice, endPrice,category);
            ViewBag.category = await _productService.GetAllActiveProductCategories();
            ViewBag.startPrice = startPrice;
            ViewBag.endPrice = endPrice;
            ViewBag.pageId = pageId;
            return View(model);
        }

        #endregion

        #region DetailProduct
        [HttpGet("product-Detail/{productId}/{title}")]
        public async Task<IActionResult> ProductDetail(long productId,string title)
        {
            var res = await _productService.GetProductDetail(productId);
            if (res == null)
            {
                return NotFound();
            }

            return View(res);
        }

        #endregion
    }
}
