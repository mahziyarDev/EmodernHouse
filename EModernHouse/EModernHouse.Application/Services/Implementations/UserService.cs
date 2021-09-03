﻿using System;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using EModernHouse.Application.Services.Interfaces;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;

namespace EModernHouse.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region Ctor

        private readonly IGenericRepository<User> _useRepository;
        private readonly IPasswordHelper _passwordHelper;
        private readonly ISmsService _smsService;

        public UserService(IGenericRepository<User> useRepository, IPasswordHelper passwordHelper, ISmsService smsService)
        {
            _useRepository = useRepository;
            _passwordHelper = passwordHelper;
            _smsService = smsService;
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
                    Password = _passwordHelper.EncodePasswordMd5(Register.Password),
                    EmailActiveCode = Guid.NewGuid().ToString("N"),
                    MobileActiveCode = new Random().Next(10000, 999999).ToString()
                };

                await _useRepository.AddEntity(user);
                await _useRepository.SaveChanges();
                // await _smsService.SendVerificationSms(user.Mobile, user.MobileActiveCode);
                return RegisterUserResult.Success;
            }

            return RegisterUserResult.MobilExists;
        }

        public async Task<bool> IsUserExistsByMobileNumber(string mobile)
        {
            return await _useRepository.GetQuery().AsQueryable().AnyAsync(s => s.Mobile == mobile);
        }

        public async Task<LoginUserResult> GetUserForLogin(LoginUserDTO login)
        {
            var user = await _useRepository.GetQuery()
                .AsQueryable().SingleOrDefaultAsync(s => s.Mobile == login.Mobile);

            if (user == null) return LoginUserResult.NotFount;
            if (user.Password != _passwordHelper.EncodePasswordMd5(login.Password)) return LoginUserResult.NotFount;
            if (!user.IsMobileActive) return LoginUserResult.NotActivated;

            return LoginUserResult.Success;
        }

        public async Task<EModernHouse.DataLayer.Entities.Account.User> GetUserByMobile(string mobil)
        {
            return await _useRepository.GetQuery().AsQueryable().SingleOrDefaultAsync(s => s.Mobile == mobil);
        }

        public async Task<ForgotPasswordResult> RecoverUserPassword(ForgotPasswordDTO forgotPassword)
        {
            var user = await GetUserByMobile(forgotPassword.Mobile);
            if (user == null) return ForgotPasswordResult.NotFount;
            if (!user.IsMobileActive) return ForgotPasswordResult.NotActivated;
            var newPassword = new Random().Next(100000, 9999999).ToString();
            user.Password = _passwordHelper.EncodePasswordMd5(newPassword);
            _useRepository.EditEntity(user);
            //TODO SEND MESSAGE
            await _useRepository.SaveChanges();

            return ForgotPasswordResult.Success;
        }

        public async Task<bool> ActivateMobile(ActivateMobileDTO activate)
        {
            var user = await _useRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s => s.Mobile == activate.Mobile);
            if (user != null)
            {
                if (user.MobileActiveCode == activate.MobileActiveCode)
                {
                    user.IsMobileActive = true;
                    user.MobileActiveCode = new Random().Next(100000, 9999999).ToString();
                    await _useRepository.SaveChanges();

                    return true;
                }

            }

            return false;
        }

        public async Task<ChangePasswordResult> ChangeUserPassword(ChangePasswordDTO changePass, long currentUserId)
        {
            var user = await _useRepository.GetEntityById(currentUserId);
            var currentPasswordUser = user.Password;
            var currentUserPassword = _passwordHelper.EncodePasswordMd5(changePass.CurrentPassword);
            var newPasswordUser = _passwordHelper.EncodePasswordMd5(changePass.NewPassword);
            if (currentUserPassword != currentPasswordUser)
            {
                return ChangePasswordResult.Error;
            }

            if (currentUserPassword == newPasswordUser)
            {
                return ChangePasswordResult.Repetition;
            }

            user.Password = newPasswordUser;
            _useRepository.EditEntity(user);
            await _useRepository.SaveChanges();
            return ChangePasswordResult.Success;
        }

        public async Task<EditUserProfileDTO> GetProfileForEdit(long userId)
        {
            var user = await _useRepository.GetEntityById(userId);

            if (user == null)
            {
                return null;
            }

            return new EditUserProfileDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Avatar = user.Avatar
            };
        }

        public async Task<EditUserProfileResult> EditUserProfile(EditUserProfileDTO profile, long userId, IFormFile avatarImage)
        {
            var user = await _useRepository.GetEntityById(userId);

            if (user == null) return EditUserProfileResult.NotFound;
            if (user.IsBlocked) return EditUserProfileResult.IsBlocked;
            if (!user.IsMobileActive) return EditUserProfileResult.IsNotActive;

            user.FirstName = profile.FirstName;
            user.LastName = profile.LastName;
            if (avatarImage != null && avatarImage.IsImage())
            {
                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(avatarImage.FileName);
                avatarImage.AddImageToServer(imageName, PathExtensions.UserAvatarOriginServer, 100, 100, PathExtensions.UserAvatarThumbServer, user.Avatar);
                user.Avatar = imageName;
            }

            _useRepository.EditEntity(user);
            await _useRepository.SaveChanges();
            return EditUserProfileResult.Success;
        }

        public async Task<User> GetUSerById(long userID)
        {
            return await _useRepository.GetEntityById(userID);
        }
        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _useRepository.DisposeAsync();
        }

        #endregion

    }
}