using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Product;
using Microsoft.AspNetCore.Http;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        #region Ctor

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        #region CreateProduct
        [HttpGet("create-product")]
        public async Task<IActionResult> CreateProduct()
        {
            ViewBag.MainCategories = await _productService.GetAllActiveProductCategories();
            return View();
        }

        [HttpPost("create-product")]
        public async Task<IActionResult> CreateProduct(CreateProductDTO create,IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                // TODO : Create Product
            }
            ViewBag.MainCategories = await _productService.GetAllActiveProductCategories();
            return View();
        }
        #endregion
    }
}
