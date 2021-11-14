using Microsoft.AspNetCore.Mvc;
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
        private readonly IContactService _contactService;
        public ProductController(IProductService productService, IContactService contactService)
        {
            _productService = productService;
            _contactService = contactService;
        }

        #endregion

        #region ProductList
        [HttpGet("product-archive")]
        [HttpGet("product-archive/{category}")]
        public async Task<IActionResult> Products(int pageId=1,int take=20,int startPrice=0,int endPrice=0,long? category=null,string categoryName = "همه دسته بندی ها")
        {
            var model = await _productService.GetProductsForUsers(pageId, take, startPrice, endPrice,category);
            ViewBag.category = await _productService.GetAllActiveProductCategories();
            ViewBag.startPrice = startPrice;
            ViewBag.endPrice = endPrice;
            ViewBag.pageId = pageId;
            ViewBag.categoryName = categoryName;
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

            ViewBag.Comment = await _contactService.ShowProductCommentByProductId(productId);
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
        [HttpGet("delete-favorite/{productId}")]
        public async Task<JsonResult> RemoveProductInterest(long productId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var res = await _productService.RemoveProductInterest(productId, User.GetUserId());
                if (res)
                {
                    return JsonResponseStatus.SendStatus(
                        JsonResponseStatusType.Success,
                        "محصول از علاقه مندی ها حذف شد",
                        null
                    );
                }
            }
            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "برای انجام عملیات نیاز به ثبت نام / لاگین در سایت است",
                null
            );
        }
        #endregion
    }
}
