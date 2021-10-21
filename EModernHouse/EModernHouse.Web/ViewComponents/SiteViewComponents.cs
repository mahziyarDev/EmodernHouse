using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.PresentationExtentions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace EModernHouse.Web.ViewComponents
{
    #region SiteHeader

    public class SiteHeaderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;


        public SiteHeaderViewComponent(ISiteService siteService, IUserService userService, IProductService productService)
        {
            _siteService = siteService;
            _userService = userService;
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteSetting = await _siteService.GetDefaultSiteSetting();

            ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            };
            ViewBag.Categories = await _productService.GetAllActiveProductCategories();
            ViewBag.interestCount = await _productService.GetAllProductInterest(User.GetUserId());
            return View("SiteHeader");
        }
    }

    #endregion

    #region SiteFooter

    public class SiteFooterViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public SiteFooterViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteSetting = await _siteService.GetDefaultSiteSetting();
            return View("SiteFooter");
        }
    }

    #endregion

    #region HomeSlider

    public class HomeSliderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomeSliderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetAllActiveSlider();
            return View("HomeSlider", sliders);
        }
    }

    #endregion

    #region UserOrder

    public class UserOrderViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public UserOrderViewComponent(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var openOrder = await _orderService.GetUserLatestOpenOrder(User.GetUserId());
            return View("UserOrder", openOrder);
        }
    }
    public class UserOrderResponsiveViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public UserOrderResponsiveViewComponent(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var openOrder = await _orderService.GetUserLatestOpenOrder(User.GetUserId());
            return View("UserOrderResponsive", openOrder);
        }
    }

    #endregion
}