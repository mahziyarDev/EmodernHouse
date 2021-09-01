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

        public TicketController(IContactService contactService)
        {
            _contactService = contactService;
        }


        #endregion

        #region List Ticke

        public IActionResult Index()
        {
            return View();
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

    }
}
