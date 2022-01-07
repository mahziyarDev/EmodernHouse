using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.DTOs.UserPanel;
using EModernHouse.DataLayer.Entities.Account;
using Microsoft.AspNetCore.Http;


namespace EModernHouse.Application.Services.Interfaces
{
    public interface IUserService:IAsyncDisposable
    {
        Task<RegisterUserResult> RegisterUSer(RegisterUserDTO Register);
        Task<bool> IsUserExistsByMobileNumber(string mobile);
        Task<LoginUserResult> GetUserForLogin(LoginUserDTO login);
        Task<EModernHouse.DataLayer.Entities.Account.User> GetUserByMobile(string mobil);
        Task<ForgotPasswordResult> RecoverUserPassword(ForgotPasswordDTO forgotPassword);
        Task<bool> ActivateMobile(ActivateMobileDTO activate);
        Task<ChangePasswordResult> ChangeUserPassword(ChangePasswordDTO changePass, long currentUserId);
        Task<EditUserProfileDTO> GetProfileForEdit(long userId);
        Task<EditUserProfileResult> EditUserProfile(EditUserProfileDTO profile,long userId, IFormFile avatarImage);
        Task<User> GetUSerById(long userId);
        Task<bool> UserChangeAdmin(long userId);

        #region UserForAdmin

        Task<List<User>> GetAllUser();
        Task<bool> CreateUser(CreateUserDTO createUser);
        Task<EditUserDTO> GetUserForEdit(long userId);
        Task<bool> SetUserForEdit(EditUserDTO edit,long userId);
        Task<bool> IsDeletedUser(long userId);
        Task<bool> IsBlocked(long userId);
        Task<Tuple<List<User>, int>> GetUsersForFilter(int pageId, int take, string mobile, string name, string email);
        Task<int> GetUserCount();
        #endregion

        #region userAddres

        /// <summary>
        /// پر کردن ویو مدل صفحه اصلی پنل کاربر
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>viewModel</returns>
        Task<UserPanelIndexDTO> IndexUserPanel(long userId);

        /// <summary>
        /// برای ثبت نام ادرس کاربر یا ویرایش ان
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="viewModel"></param>
        /// <returns>bool</returns>
        Task<bool> Manage(long userId,UserPanelIndexDTO viewModel);

        #endregion
    }
}