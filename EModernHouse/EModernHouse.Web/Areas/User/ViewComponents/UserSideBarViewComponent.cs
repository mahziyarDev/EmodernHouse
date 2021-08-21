using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EModernHouse.Web.Areas.User.ViewComponents
{
    public class UserSideBarViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public UserSideBarViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userService.GetUserByMobile(User.Identity.Name);
            return View("UserSidebar",user);
        }
    }
}