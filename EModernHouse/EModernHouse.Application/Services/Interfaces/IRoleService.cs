using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Roles;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IRoleService:IAsyncDisposable
    {
        long GetUserIdByMobile(string mobile);
        bool CheckRoles(long id,long userId);
    }
}