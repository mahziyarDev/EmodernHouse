using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Roles;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class RoleServices : IRoleService
    {
        #region Ctor

        private readonly IGenericRepository<Roles> _roleRepository;
        private readonly IGenericRepository<UserSelectedRole> _userSelectedRoleRepository;
        public RoleServices(IGenericRepository<Roles> roleRepository, IGenericRepository<UserSelectedRole> userSelectedRoleRepository)
        {
            _roleRepository = roleRepository;
            _userSelectedRoleRepository = userSelectedRoleRepository;
        }
        #endregion

        public async Task<List<Roles>> GetRoles()
        {
            return await _roleRepository.GetQuery().AsQueryable().ToListAsync();
        }

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _roleRepository.DisposeAsync();
            await _userSelectedRoleRepository.DisposeAsync();
        }

        #endregion


    }
}