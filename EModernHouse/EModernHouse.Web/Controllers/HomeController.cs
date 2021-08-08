using EModernHouse.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace EModernHouse.Web.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region Ctor

        private ISmsService _smsService;

        public HomeController(ISmsService smsService)
        {
            _smsService = smsService;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            await _smsService.SendSms();
            return View();
        }

        [Authorize]
        public IActionResult test()
        {
            return Content("hello");
        }
      
    }
}
