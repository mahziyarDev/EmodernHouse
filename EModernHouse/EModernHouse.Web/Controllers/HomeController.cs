using EModernHouse.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace EModernHouse.Web.Controllers
{
    public class HomeController : SiteBaseController
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult test()
        {
            return Content("hello");
        }
      
    }
}
