using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.CodeAnalysis.Differencing;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        #region Ctor

        private readonly IProductService _productService;

        public CategoryController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        #region CategoryList

        [HttpGet("list-category")]
        public async Task<IActionResult> CategoriesList()
        {
            var categories = await _productService.GetAllProductCategoriesForList();
            return View(categories);
        }

        #endregion

        #region createMainCategories

        [HttpPost("create-main-category")]
        public async Task<IActionResult> CreateMainCategory(string nameCategory, IFormFile imageCategory)
        {
            
            if (!string.IsNullOrEmpty(nameCategory) && imageCategory != null)
            {
               
                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(imageCategory.FileName);
                imageCategory.AddImageToServer(imageName, PathExtensions.CategoryImageImageOriginServer, 150, 150, PathExtensions.CategoryImageImageThumbServer);
                
                var res = await _productService.CreateMainCategory(nameCategory, imageName);
                if (res)
                {
                    TempData[SuccessMessage] = "موفقیت امیز بود";
                    return RedirectToAction("CategoriesList");
                }

            }
            TempData[ErrorMessage] = "مقادیر خواسته شد را وارد نمایید";
            return RedirectToAction("CategoriesList");
        }
        
        [HttpGet("CreateSubGroups")]
        public async Task<IActionResult> CreateSubGroups(long groupId,string groupName)
        {
            if (!string.IsNullOrEmpty(groupName))
            {
                var newCategory =await _productService.CreateSubGroups(groupId, groupName);
                if (newCategory)
                {
                    TempData[SuccessMessage] = "با موفقیت ثبت شد";
                    return RedirectToAction("CategoriesList");
                }
            }

            TempData[ErrorMessage] = "مقادیر خواسته شده را وارد نماید";
            return RedirectToAction("CategoriesList");
        }
        #endregion

        #region EditMainCategory

        [HttpGet("edit-main-category/{categoryId}")]
        public async Task<IActionResult> EditMainCategory(long categoryId)
        {
            var category = await _productService.GetMainCategoryForEdit(categoryId);
            return View(category);
        }

        [HttpPost("edit-main-category/{categoryId}")]
        public async Task<IActionResult> EditMainCategory(long categoryId,EditProductCategoryDTO edit,IFormFile imageCategory)
        {
            if (ModelState.IsValid)
            {
                if (imageCategory != null)
                {
                    var ImageCategory = Guid.NewGuid().ToString("N") + Path.GetExtension(imageCategory.FileName);
                    imageCategory.AddImageToServer(ImageCategory,PathExtensions.CategoryImageImageOriginServer,150,150,PathExtensions.CategoryImageImageThumbServer,edit.CategoryImage);
                    edit.CategoryImage = ImageCategory;
                }

                var res = await _productService.SetMainCategoryForEdit(edit);
                if (res)
                {
                    TempData[SuccessMessage] = "ویراش موفقیت امیز بود";
                    return RedirectToAction("CategoriesList");
                }

                TempData[ErrorMessage] = "موفقیت امیز نبود";
            }

            return View(edit);
        }

        #endregion

        #region DeleteCategory

        [HttpGet("delete-category/{categoryId}")]
        public async Task<IActionResult> DeleteCategoryById(long categoryId)
        {
            var res = await _productService.DeleteCategories(categoryId);
            if (res)
            {
                return JsonResponseStatus.SendStatus(
                    JsonResponseStatusType.Success,
                    "حذف شد",
                    null
                );
            }
            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "حذف نشد",
                null
            );
        }

        #endregion
    }
}
