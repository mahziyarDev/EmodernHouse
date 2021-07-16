using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Account;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IUserService:IAsyncDisposable
    {
        Task<RegisterUserResult> RegisterUSer(RegisterUserDTO Register);
        Task<bool> IsUserExistsByMobileNumber(string mobile);
    }
}