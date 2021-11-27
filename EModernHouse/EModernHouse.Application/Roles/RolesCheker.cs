using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EModernHouse.Application.Roles
{
    public class RolesCheker : AuthorizeAttribute, IAuthorizationFilter
    {
        private  IRoleService _roleService;
        private int _userRole = 0;
        public RolesCheker(int id)
        {
            _userRole = id;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _roleService = (IRoleService)context.HttpContext.RequestServices.GetService(typeof(IRoleService));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                long userId = _roleService.GetUserIdByMobile(context.HttpContext.User.Identity.Name);
                var res = _roleService.CheckRoles(_userRole, userId);
                if (!res)
                {
                    
                    context.Result = new RedirectResult("/Login"); 
                    
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }

}