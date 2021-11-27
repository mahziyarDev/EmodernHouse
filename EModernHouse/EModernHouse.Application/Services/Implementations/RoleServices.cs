using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Roles;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class RoleServices : IRoleService
    {
        #region Ctor

        private readonly IGenericRepository<DataLayer.Entities.Roles.Roles> _roleRepository;
        private readonly IGenericRepository<UserSelectedRole> _userSelectedRoleRepository;
        private readonly IGenericRepository<User> _useRepository;
        public RoleServices(IGenericRepository<DataLayer.Entities.Roles.Roles> roleRepository, IGenericRepository<UserSelectedRole> userSelectedRoleRepository, IGenericRepository<User> useRepository)
        {
            _roleRepository = roleRepository;
            _userSelectedRoleRepository = userSelectedRoleRepository;
            _useRepository = useRepository;
        }
        #endregion

        public long GetUserIdByMobile(string mobile)
        {
            var user = _useRepository.GetQuery().SingleOrDefault(s => s.Mobile == mobile);
            return user.Id;
        }
        public bool CheckRoles(long id, long userId)
        {
            var userRoles = _userSelectedRoleRepository.GetQuery()
                .Any(s => s.UserId == userId && s.RolesId == id);
            if (userRoles)
            {
                return true;
            }

            return false;
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