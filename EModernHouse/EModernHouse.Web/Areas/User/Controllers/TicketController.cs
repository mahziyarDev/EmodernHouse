using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.Web.PresentationExtentions;

namespace EModernHouse.Web.Areas.User.Controllers
{
    public class TicketController : UserBaseController
    {
        #region Ctor
        private readonly IContactService _contactService;
        private readonly IUserService _userService;

        public TicketController(IContactService contactService, IUserService userService)
        {
            _contactService = contactService;
            _userService = userService;
        }
        #endregion

        #region List Ticke

        [HttpGet("tickets-list")]
        public async Task<IActionResult> Index(FilterTicketDTO filter)
        {
            filter.UserId = User.GetUserId();
            filter.FilterTicketState = FilterTicketState.NotDeleted;
            filter.OrderBy = FilterTicketOrder.CreateDate_DES;

            return View(await _contactService.FilterTickets(filter));
        }

        #endregion

        #region AddTicket   

        [HttpGet("add-ticket")]
        public async Task<IActionResult> AddTicket()
        {
            return View();
        }
        [HttpPost("add-ticket"), ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTicket(AddTicketViewModel ticket)
        {
            if (ModelState.IsValid)
            {
                var result = await _contactService.AddUserTicket(ticket, User.GetUserId());
                switch (result)
                {
                    case AddTicketResult.Error:
                        TempData[ErrorMessage] = "عملیات با شکست مواجه شد";
                        break;
                    case AddTicketResult.Success:
                        TempData[SuccessMessage] = "تیکت شما با موفقیت ثبت شد";
                        TempData[InfoMessage] = "پاسخ شما به زودی ارسال خواهد شد";
                        return RedirectToAction("Index");
                }
            }

            return View(ticket);
        }

        #endregion
        #region Show Ticket detail
        [HttpGet("tickets/{ticketId}")]
        public async Task<IActionResult> TicketDetail(long ticketId)
        {
            var ticket = await _contactService.GetTicketForShow(ticketId, User.GetUserId());
            ViewBag.user = await _userService.GetUSerById(ticket.Ticket.OwnerId);
            if (ticket == null) return NotFound();

            return View(ticket);
        }

        #endregion

        #region AddNewAnswer
        [HttpPost("answer-ticket"), ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewAnswer(AnswerTicketDTO answer)
        {
            if (string.IsNullOrEmpty(answer.Text))
            {
                TempData[ErrorMessage] = "لطفا متن پیام خود را وارد نمایید";
            }
            if (ModelState.IsValid)
            {
                var res = await _contactService.AnswerTicket(answer, User.GetUserId());
                switch (res)
                {
                    case AnswerTicketResult.NotForUser:
                        TempData[ErrorMessage] = "عدم دسترسی";
                        TempData[InfoMessage] = "در صورت تکرار این مورد ، دسترسی شما به صورت کلی از سیستم قطع خواهد شد";
                        return RedirectToAction("Index");
                    case AnswerTicketResult.NotFound:
                        TempData[WarningMessage] = "اطلاعات مورد نظر یافت نشد";
                        return RedirectToAction("Index");
                    case AnswerTicketResult.Success:
                        TempData[SuccessMessage] = "اطلاعات مورد نظر با موفقیت ثبت شد";
                        break;
                }
            }

            return RedirectToAction("TicketDetail", "Ticket", new { area = "User", ticketId = answer.Id });
        }

        #endregion
    }
}
