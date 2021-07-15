using System.Reflection.Emit;
using EModernHouse.Application.Services.Interfaces;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Repository;

namespace EModernHouse.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region Ctor

        private readonly IGenericRepository<User> _useRepository;

        public UserService(IGenericRepository<User> useRepository)
        {
            _useRepository = useRepository;
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