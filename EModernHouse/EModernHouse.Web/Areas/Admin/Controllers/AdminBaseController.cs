using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Roles;
using Microsoft.AspNetCore.Authorization;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    [Authorize]
    [RolesCheker(2)]
    [Area("Admin")]
    [Route("star-site-admin")]
    public class AdminBaseController : Controller
    {
        protected string ErrorMessage = "ErrorMessage";
        protected string SuccessMessage = "SuccessMessage";
        protected string WarningMessage = "WarningMessage";
        protected string InfoMessage = "InfoMessage";
    }
}
