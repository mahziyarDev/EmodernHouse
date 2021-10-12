using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Order;
using EModernHouse.Web.Http;
using EModernHouse.Web.PresentationExtentions;
using Microsoft.AspNetCore.Authorization;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class OrderController : UserBaseController
    {
        #region Ctor

        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        #endregion

        [AllowAnonymous]
        [HttpPost("add-product-to-order")]
        public async Task<IActionResult> AddProductToOrder(AddProductToOrderDTO order)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    await _orderService.AddProductToOpenOrder(order,User.GetUserId());
                    return JsonResponseStatus.SendStatus(JsonResponseStatusType.Success, "محصول با موفقیت اضافه شد", null);
                    //TempData[SuccessMessage] = "محصول به سبد خرید شما اضافه شد";
                }
                return JsonResponseStatus.SendStatus(JsonResponseStatusType.Warning, "برای ثبت محصول باید در سایت ثبت نام /لاگین کنید", null);
                    //TempData[WarningMessage] = "برای ثبت محصول باید وارد سایت شوید";
            }
            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "ثبت محصول همراه با خطا مواجه شد", null);
            
        }
    }
}
