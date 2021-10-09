using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;
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

        #region ProductList

        [HttpGet("product-list")]
        public async Task<IActionResult> ProductList(int pageId = 1, int take = 5, string productName = "")
        {
            var productFilter = await _productService.GetProductForFilter(pageId, take, productName);
            ViewBag.PageId = pageId;
            ViewBag.Take = take;
            ViewBag.ProducrName = productName;
          
            return View(productFilter);
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
        public async Task<IActionResult> CreateProduct(CreateProductDTO create, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage == null && !productImage.IsImage())
                {
                    TempData[WarningMessage] = "عکس انتخاب نشده یا فرمت نادرستی دارد";
                    ModelState.AddModelError("productImage", "عکس انتخاب نشده یا فرمت نادرستی دارد");
                }
                var imageProduct = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);
                productImage.AddImageToServer(imageProduct, PathExtensions.ProductImageOriginServer, 150, 150, PathExtensions.ProductImageThumbServer);

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
        public async Task<IActionResult> EditProduct(long productId, EditProductDTO edit, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage != null)
                {
                    var imageProduct = Guid.NewGuid().ToString("N") + Path.GetExtension(productImage.FileName);
                    productImage.AddImageToServer(imageProduct, PathExtensions.ProductImageOriginServer, 150, 150, PathExtensions.ProductImageThumbServer, edit.ImageNameProduct);
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

        #region ProductGalleries

        [HttpGet("create-gallery/{productId}")]
        public async Task<IActionResult> CreateProductGallery(long productId)
        {
            ViewBag.productId = productId;
            ViewBag.productImages = await _productService.GetAllGalleryForProduct(productId);
            return View();
        }

        [HttpPost("create-gallery/{productId}")]
        public async Task<IActionResult> CreateProductGallery(CreateProductGalleryDTO gallery, IFormFile imageGallery, long productId)
        {
            if (ModelState.IsValid)
            {
                if (imageGallery != null && imageGallery.IsImage())
                {
                    var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(imageGallery.FileName);
                    imageGallery.AddImageToServer(imageName, PathExtensions.ProductGalleryImageOriginServer, 150, 150, PathExtensions.ProductGalleryImageThumbServer);
                    gallery.ImageName = imageName;

                    var res = await _productService.AddImageProductForGallery(gallery);
                    if (res)
                    {
                        TempData[SuccessMessage] = "عکس با موفقیت ذخیره شد";
                        return RedirectToAction("CreateProductGallery");
                    }

                    TempData[ErrorMessage] = "عملیات ثبت موفق نبود";
                }

                TempData[ErrorMessage] = "عکس محصول را درست انتخاب کنید";
            }
            ViewBag.productId = productId;
            return View(gallery);
        }

        [HttpPost("edit-product-gallery/{galleryId}")]
        public async Task<IActionResult> EditProductGallery(long productId, long galleryId, string imageName,int displayPriority,string alt,IFormFile newGalleryImage)
        {
            if (productId != null && galleryId != null && !string.IsNullOrEmpty(imageName) && displayPriority != null)
            {
                var newImageString = imageName;

                if (newGalleryImage != null)
                {
                    var newImageGaller = Guid.NewGuid().ToString("N") + Path.GetExtension(newGalleryImage.FileName);
                    newGalleryImage.AddImageToServer(newImageGaller,PathExtensions.ProductGalleryImageOriginServer,150,150,PathExtensions.ProductGalleryImageThumbServer,imageName);
                    newImageString = newImageGaller;
                }

                var res = await _productService.EditProductGallery(galleryId, displayPriority, alt, newImageString);
                if (res)
                {
                    TempData[SuccessMessage] = "ویرایش موفقیت امیز بود";
                    return Redirect("/Admin/create-gallery/" + productId);
                }
            }

            TempData[ErrorMessage] = "مقادیر خواسته شده را وارد نمایید";
            return Redirect("/Admin/create-gallery/" + productId);
        }

        [HttpGet("delete-product-gallery/{galleryId}")]
        public async Task<IActionResult> DeleteProductGallery(long productId ,long galleryId)
        {
            var res = await _productService.DeleteProductGalleryById(galleryId);
            
            TempData[SuccessMessage] = "با موفقیت حذف شد";
            return Redirect("/Admin/create-gallery/" + res);
        }
        #endregion

        #region ProductColor
        [HttpGet("create-product-color/{productId}")]
        public async Task<IActionResult> CreateProductColor(long productId)
        {
            ViewBag.productId = productId;
            ViewBag.ProductColers = await _productService.GetProductColorByproductId(productId);
            return View();
        }

        [HttpPost("create-product-color/{productId}")]
        public async Task<IActionResult> CreateProductColor(CreateProductColorDTO create,long productId)
        {
            if (ModelState.IsValid)
            {
                create.ProductId = productId;
                var res = await _productService.CreateColorProduct(create);
                if (res)
                {
                    TempData[SuccessMessage] = "رنگ مورد نظر اضافه شد";
                    return Redirect("/Admin/create-product-color/" + productId);
                }
            }
            return View(create);
        }

        [HttpGet("edit-product-color/{colorId}")]
        public async Task<IActionResult> EditProductColor(long colorId,long productId, string colorName,string colorCode,int price)
        {
            if (!string.IsNullOrEmpty(colorCode) && !string.IsNullOrEmpty(colorName) && price > 0)
            {
                var res = await _productService.EditProductColor(colorId, colorName, colorCode, price);
                if (res)
                {
                    TempData[SuccessMessage] = "باموفقیت انجام شد";
                    return Redirect("/Admin/create-product-color/" + productId);
                }
            }   
            return Redirect("/Admin/create-product-color/" + productId);
        }

        [HttpGet("delete-product-color/{colorId}")]
        public async Task<IActionResult> DeleteProductColor(long colorId)
        {
            var res = await _productService.DeleteProductColorById(colorId);
            TempData[SuccessMessage] = "رنگ محصول با موفقیت حذف شد";
            return Redirect("/Admin/create-product-color/"+res);
        }
        #endregion

      
    }
}
