using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.Http;
using EModernHouse.Web.PresentationExtentions;

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

        #region ProductInterest
        [HttpGet("add-to-product-Interest/{productId}")]
        public async Task<JsonResult> AddInterest(long productId)   
        {
            if (User.Identity.IsAuthenticated)
            {
                var res =await _productService.AddProductToInterest(User.GetUserId(), productId);
                if (res)
                {
                   return JsonResponseStatus.SendStatus(
                        JsonResponseStatusType.Success,
                        "محصول با موفقیت به علاقه مندی های شما اضافه شد",
                        null
                        );
                }
            }

            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "شما قبلا این محصول را به علاقه مندی های خود اضافه کرده اید",
                null
            );
        }

        #endregion
    }
}
