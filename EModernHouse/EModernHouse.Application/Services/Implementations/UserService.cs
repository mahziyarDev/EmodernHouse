using System;
using System.Linq;
using System.Reflection.Emit;
using EModernHouse.Application.Services.Interfaces;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region Ctor

        private readonly IGenericRepository<User> _useRepository;
        private readonly IPasswordHelper _passwordHelper;

        public UserService(IGenericRepository<User> useRepository, IPasswordHelper passwordHelper)
        {
            _useRepository = useRepository;
            _passwordHelper = passwordHelper;
        }

        #endregion

        public async Task<RegisterUserResult> RegisterUSer(RegisterUserDTO Register)
        {
            if (!await IsUserExistsByMobileNumber(Register.Mobile))
            {
                var user = new User
                {
                    FirstName = Register.FirstName,
                    LastName = Register.LastName,
                    Mobile = Register.Mobile,
                    Password = _passwordHelper.EncodePasswordMd5(Register.Password)
                };

                await _useRepository.AddEntity(user);
                await _useRepository.SaveChanges();
                //TODO : Send Text To Mobile
                return RegisterUserResult.Success;
            }

            return RegisterUserResult.MobilExists;
        }

        public async Task<bool> IsUserExistsByMobileNumber(string mobile)
        {
            return await _useRepository.GetQuery().AsQueryable().AnyAsync(s => s.Mobile == mobile);
        }


        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _useRepository.DisposeAsync();
        }

        #endregion

    }
}