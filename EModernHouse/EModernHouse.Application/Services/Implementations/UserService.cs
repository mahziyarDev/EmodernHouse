using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using EModernHouse.Application.Services.Interfaces;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Roles;
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
        private readonly IGenericRepository<UserAddress> _userAddressRepository;
        private readonly IGenericRepository<UserSelectedRole> _userSelectedRoleRepository;
        private readonly IGenericRepository<DataLayer.Entities.Roles.Roles> _rolesRepository;

        public UserService(IGenericRepository<User> useRepository, IPasswordHelper passwordHelper, ISmsService smsService, IGenericRepository<UserAddress> userAddressRepository, IGenericRepository<UserSelectedRole> userSelectedRoleRepository, IGenericRepository<DataLayer.Entities.Roles.Roles> rolesRepository)
        {
            _useRepository = useRepository;
            _passwordHelper = passwordHelper;
            _smsService = smsService;
            _userAddressRepository = userAddressRepository;
            _userSelectedRoleRepository = userSelectedRoleRepository;
            _rolesRepository = rolesRepository;
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
                var selectedRole = new UserSelectedRole
                {
                    RolesId = 3,
                    UserId = user.Id
                };
                await _userSelectedRoleRepository.AddEntity(selectedRole);
                await _userSelectedRoleRepository.SaveChanges();
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

        #region UserForAdmin

        public async Task<List<User>> GetAllUser()
        {
            return await _useRepository.GetQuery().AsQueryable().Where(s => !s.IsDelete && !s.IsBlocked)
                .ToListAsync();
        }

        public async Task<bool> CreateUser(CreateUserDTO createUser)
        {
            var user = new User
            {
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Mobile = createUser.Mobile,
                Email = createUser.Email,
                Password = _passwordHelper.EncodePasswordMd5(createUser.Password),
                EmailActiveCode = Guid.NewGuid().ToString("N"),
                MobileActiveCode = new Random().Next(10000, 999999).ToString(),
                IsEmailActive = createUser.IsEmailActive,
                IsMobileActive = createUser.IsMobileActive,
            };
            await _useRepository.AddEntity(user);
            await _useRepository.SaveChanges();
            var userRole = new UserSelectedRole
            {
                UserId = user.Id,
                RolesId = 3,
            };
            await _userSelectedRoleRepository.AddEntity(userRole);
            await _userSelectedRoleRepository.SaveChanges();
            return true;
        }

        public async Task<EditUserDTO> GetUserForEdit(long userId)
        {
            var user = await GetUSerById(userId);

            return new EditUserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                
            };
        }

        public async Task<bool> SetUserForEdit(EditUserDTO edit, long userId)
        {
            var user = await GetUSerById(userId);

            
                user.FirstName = edit.FirstName;
                user.LastName = edit.LastName;
                user.Email = edit.Email;
                user.IsEmailActive = false;
                _useRepository.EditEntity(user);
                await _useRepository.SaveChanges();
                return true;
            

            
        }

        public async Task<bool> IsDeletedUser(long userId)
        {
            var user = await _useRepository.GetEntityById(userId);
            user.IsDelete = true;
            _useRepository.EditEntity(user);
            await _useRepository.SaveChanges();
            return true;
        }

        public async Task<bool> IsBlocked(long userId)
        {
            var user = await _useRepository.GetEntityById(userId);
            user.IsBlocked = true;
            _useRepository.EditEntity(user);
            await _useRepository.SaveChanges();
            return true;
        }

        public async Task<bool> UserChangeAdmin(long userId)
        {
            var user = await _useRepository.GetEntityById(userId);
            if (user==null)
            {
                return false;
            }

            var userRole = new UserSelectedRole
            {
                UserId = user.Id,
                RolesId = 2,
            };
            await _userSelectedRoleRepository.AddEntity(userRole);
            await _userSelectedRoleRepository.SaveChanges();
            return true;
        }
        public async Task<Tuple<List<User>, int>> GetUsersForFilter(int pageId, int take, string mobile, string name, string email)
        {
            IQueryable<User> users = _useRepository.GetQuery().AsQueryable().Where(s=>!s.IsDelete && !s.IsBlocked);

            #region fillterForString

            if (!string.IsNullOrEmpty(name))
            {
                users = users.Where(s => s.FirstName.Contains(name) || s.LastName.Contains(name));
            }

            if (!string.IsNullOrEmpty(email))
            {
                users = users.Where(s => s.Email.Contains(email));
            }

            if (!string.IsNullOrEmpty(mobile))
            {
                users = users.Where(s => s.Mobile.Contains(mobile));
            }

            #endregion



            int skip = (pageId - 1) * take;
            int pageCount = (users.Count() % take == 0 ? users.Count() / take : (users.Count() / take) + 1);
            List<User> result = await users.Skip(skip).Take(take).ToListAsync();
            return Tuple.Create(result, pageCount);

        }

        public async Task<int> GetUserCount()
        {
            var userCount = await _useRepository.GetQuery().AsQueryable().ToListAsync();
            return userCount.Count();
        }
        #endregion

        #region userAddres

        public async Task<bool> UserAddressIsYesOrNo(long userId)
        {
            var userAddress = _userAddressRepository.GetQuery().AsQueryable().Any(s => s.UserId == userId);
            if (userAddress)
            {
                return true;
            }

            return false;
        }
        public async Task<bool> InsertUserAddress(long userId, string address)
        {
            var newAddress = new UserAddress
            {
                UserId = userId,
                Address = address,
                IsDelete = false,
            };
            await _userAddressRepository.AddEntity(newAddress);
            await _userAddressRepository.SaveChanges();
            return true;
        }

        public async Task<UserAddress> GetAddress(long userId)
        {
            var userAddress = await _userAddressRepository.GetQuery().AsQueryable()
                .Include(s => s.User)
                .SingleOrDefaultAsync(s => s.UserId == userId);
            return userAddress;
        }

        public async Task<bool> EditAddress(long userId, string address)
        {
            var userAddress = await _userAddressRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s=>s.UserId == userId);
            if (userAddress == null) return false;
            userAddress.Address = address;
            _userAddressRepository.EditEntity(userAddress);
            await _userAddressRepository.SaveChanges();
            return true;

        }
        #endregion

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _useRepository.DisposeAsync();
        }

        #endregion

    }
}