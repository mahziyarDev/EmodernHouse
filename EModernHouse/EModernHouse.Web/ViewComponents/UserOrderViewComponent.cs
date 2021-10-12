using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Web.PresentationExtentions;
using Microsoft.AspNetCore.Mvc;

namespace EModernHouse.Web.ViewComponents
{
    public class UserOrderViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;

        public UserOrderViewComponent(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var openOrder = _orderService.GetUserLatestOpenOrder(User.GetUSerId());
            return View("UserOrder",openOrder);
        }
    }
}