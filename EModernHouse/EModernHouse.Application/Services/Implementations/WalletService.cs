using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Wallet;
using EModernHouse.DataLayer.Repository;

namespace EModernHouse.Application.Services.Implementations
{
    public class WalletService : IWalletService
    {
        #region Ctor

        private readonly IGenericRepository<SellerWallet> _sellerWalletRepository;

        public WalletService(IGenericRepository<SellerWallet> sellerWalletRepository)
        {
            _sellerWalletRepository = sellerWalletRepository;
        }


        #endregion


        public async Task AddWallet(SellerWallet wallet)
        {
            await _sellerWalletRepository.AddEntity(wallet);
            await _sellerWalletRepository.SaveChanges();
        }

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _sellerWalletRepository.DisposeAsync();
        }

        #endregion

    }
}