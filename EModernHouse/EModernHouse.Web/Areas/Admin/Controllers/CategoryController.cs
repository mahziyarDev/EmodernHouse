using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.Http;
using Microsoft.AspNetCore.Http;

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

        public async Task<IActionResult> CreateCategory(string nameCategory, IFormFile imageCategory)
        {
            if (!string.IsNullOrEmpty(nameCategory) && imageCategory != null)
            {


                var res = await _productService.CreateCategory(name)
            }
        }
        #endregion

        #region createCategories



        #endregion
    }
}
