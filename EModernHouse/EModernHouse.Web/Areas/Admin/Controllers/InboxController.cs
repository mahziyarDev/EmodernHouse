using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Contacts;
using EModernHouse.Web.PresentationExtentions;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class InboxController : AdminBaseController
    {
        #region CTOR

        private readonly IContactService _contactService;
        public InboxController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #endregion

        [HttpGet("inbox")]
        public IActionResult Index()
        {
            return View();
        }

        #region Tickets

        [HttpGet("show-ticket-support")]
        public async Task<IActionResult> ShowTicketsSupport()
        {
            return View(await _contactService.GetTicketsSupport());
        }

        [HttpGet("show-ticket-technical")]
        public async Task<IActionResult> ShowTicketsTechnical()
        {
            return View(await _contactService.GetTicketTechnical());
        }

        [HttpGet("show-ticket-Academy")]
        public async Task<IActionResult> ShowTicketsAcademy()
        {
            return View(await _contactService.GetTicketAcademy());
        }

        [HttpGet("show-ticket/{ticketId}")]
        public async Task<IActionResult> ShowTicket(long ticketId)
        {
            return View(await _contactService.GetMessagesById(ticketId));
        }

        [HttpPost("answer-ticket")]
        public async Task<IActionResult> SendAnswerTicket(TicketMessage message)
        {
            if (ModelState.IsValid)
            {
                var res = await _contactService.AnswerTicket(message);
                if (res)
                {
                    TempData[SuccessMessage] = "پاسخ شما ارسال شد";
                    return Redirect("show-ticket/"+message.TicketId);
                }
            }
            TempData[WarningMessage] = "عملیات موفق نبود";
            return Redirect("show-ticket/" + message.TicketId);
        }
        #endregion

        #region Email



        #endregion
    }
}
