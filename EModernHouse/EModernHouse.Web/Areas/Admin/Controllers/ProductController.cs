using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.Web.Http;
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
                if (productImage == null && !productImage.IsImage())
                {
                    TempData[WarningMessage] = "عکس انتخاب نشده یا فرمت نادرستی دارد";
                    ModelState.AddModelError("productImage", "عکس انتخاب نشده یا فرمت نادرستی دارد");
                }
                var imageProduct = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);
                productImage.AddImageToServer(imageProduct,PathExtensions.ProductImageOriginServer,150,150,PathExtensions.ProductImageThumbServer);

                var res = await _productService.CreateProduct(create, imageProduct);
                if (res)
                {
                    TempData[SuccessMessage] = "ثبت محصول با موفقیت انجام شد";
                    return Redirect("/admin/create-product");
                }
            }
            ViewBag.MainCategories = await _productService.GetAllActiveProductCategories();
            return View(create);
        }
        #endregion

        #region productCategories
        [HttpGet("product-categories/{parentId}")]
        public async Task<IActionResult> GetProductCategoriesByParentId(long parentId)
        {
            var categories = await _productService.GetAllProductCategoriesByParentId(parentId);

            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Success,
                "اطلاعات دسته بندی ها",
                categories
            );
        }

        #endregion

        #region EditProduct
        [HttpGet("edit-product/{productId}")]
        public async Task<IActionResult> EditProduct(long productId)
        {
            var res = await _productService.GetProductForEdit(productId);
            if (res == null) return NotFound();
            ViewBag.MainCategories = await _productService.GetAllActiveProductCategories();
            return View(res);
        }

        [HttpPost("edit-product/{productId}")]
        public async Task<IActionResult> EditProduct(long productId ,EditProductDTO edit, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage != null)
                {
                    var imageProduct = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);
                    productImage.AddImageToServer(imageProduct, PathExtensions.ProductImageOriginServer, 150, 150, PathExtensions.ProductImageThumbServer,edit.ImageNameProduct);
                    edit.ImageNameProduct = imageProduct;
                }

                var res = await _productService.EditProduct(edit);
                if (!res)
                {
                    TempData[ErrorMessage] = "ویرایش محصول انجام نشد";
                }

                TempData[SuccessMessage] = "محصول ویرایش شد";
                return RedirectToAction("EditProduct");

            }

            ViewBag.MainCategories = await _productService.GetAllActiveProductCategories();
            return View(edit);
        }

        #endregion
    }
}
