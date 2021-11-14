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


        #region addPToduct
        [AllowAnonymous]
        [HttpPost("add-product-to-order")]
        public async Task<IActionResult> AddProductToOrder(AddProductToOrderDTO order)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    await _orderService.AddProductToOpenOrder(order, User.GetUserId());
                    return JsonResponseStatus.SendStatus(JsonResponseStatusType.Success, "محصول با موفقیت اضافه شد", null);
                    //TempData[SuccessMessage] = "محصول به سبد خرید شما اضافه شد";
                }
                return JsonResponseStatus.SendStatus(JsonResponseStatusType.Warning, "برای ثبت محصول باید در سایت ثبت نام /لاگین کنید", null);
                //TempData[WarningMessage] = "برای ثبت محصول باید وارد سایت شوید";
            }
            return JsonResponseStatus.SendStatus(JsonResponseStatusType.Danger, "ثبت محصول همراه با خطا مواجه شد", null);

        }
        #endregion

        #region DetailOrder
        [HttpGet("detail-order-user")]
        public async Task<IActionResult> DetailOrder()
        {
            var order = await _orderService.GetAllOrder(User.GetUserId());
            return View(order);
        }

        #endregion

        #region orderDetialById
        [HttpGet("order-detail-byId")]
        public async Task<IActionResult> DetailOrderById(long orderId)
        {
            var details = await _orderService.GetOrderDetailById(orderId);
            return View(details);
        }

        #endregion

        #region open order

        [HttpGet("open-order")]
        public async Task<IActionResult> UserOpenOrder()
        {
            var openOrder = await _orderService.GetUserLatestOpenOrder(User.GetUserId());
            return View(openOrder);
        }

        #endregion

        #region RemoveProduct

        [HttpGet("remove-order-item/{detailId}")]
        public async Task<IActionResult> RemoveProductFromOrder(long detailId)
        {
            var res = await _orderService.RemoveOrderDetail(detailId, User.GetUserId());
            if (res)
            {
                return JsonResponseStatus.SendStatus(
                    JsonResponseStatusType.Success,
                    "محصول حذف شد",
                    null
                );
            }

            return JsonResponseStatus.SendStatus(
                JsonResponseStatusType.Danger,
                "محصول مورد نظر شما یافت نشد",
                null
            );
        }

        #endregion
    }
}
