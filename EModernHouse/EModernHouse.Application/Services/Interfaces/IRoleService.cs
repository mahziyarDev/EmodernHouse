using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Roles;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IRoleService:IAsyncDisposable
    {
        Task<List<Roles>> GetRoles();
    }
}