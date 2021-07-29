﻿using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.Entities.Account;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IUserService:IAsyncDisposable
    {
        Task<RegisterUserResult> RegisterUSer(RegisterUserDTO Register);
        Task<bool> IsUserExistsByMobileNumber(string mobile);
        Task<LoginUserResult> GetUserForLogin(LoginUserDTO login);
        Task<EModernHouse.DataLayer.Entities.Account.User> GetUserByMobile(string mobil);
        Task<ForgotPasswordResult> RecoverUserPassword(ForgotPasswordDTO forgotPassword);
    }
}