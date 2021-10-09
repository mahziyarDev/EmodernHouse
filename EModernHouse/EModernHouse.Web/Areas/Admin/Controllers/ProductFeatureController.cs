using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Product;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class ProductFeatureController : AdminBaseController
    {
        #region Ctor

        private readonly IProductService _productService;

        public ProductFeatureController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion
        #region ProductFeature

        [HttpGet("create-product-featur/{productId}")]
        public async Task<IActionResult> CreateProductFeature(long productId)
        {
            ViewBag.AllFeatures = await _productService.GetAllProductFeaturesById(productId);
            ViewBag.productId = productId;
            return View();
        }

        [HttpPost("create-product-featur/{productId}")]
        public async Task<IActionResult> CreateProductFeature(long productId, CreateProductFeatureDTO feature)
        {
            if (ModelState.IsValid)
            {
                feature.ProductId = productId;
                await _productService.CreateProductFeatures(feature);
            }
            ViewBag.AllFeatures = await _productService.GetAllProductFeaturesById(productId);
            ViewBag.productId = productId;
            return View(feature);
        }

        [HttpGet("delete-product-feature/{featureId}/{productId}")]
        public async Task<IActionResult> DeleteProductFeatureById(long featureId,long productId)
        {
            var ProductId = productId;
            var FeatureId = featureId;
            await _productService.RemoveProductFeature(FeatureId);
            return Redirect("/Admin/create-product-featur/" + ProductId);
        }
        #endregion
    }
}
