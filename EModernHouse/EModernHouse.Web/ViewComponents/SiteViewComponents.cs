using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EModernHouse.Web.ViewComponents
{
    #region SiteHeader

    public class SiteHeaderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;
        private readonly IUserService _userService;

        public SiteHeaderViewComponent(ISiteService siteService, IUserService userService)
        {
            _siteService = siteService;
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteSetting = await _siteService.GetDefaultSiteSetting();

            ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            };

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
            return View("HomeSlider",sliders);
        }
    }

    #endregion
}