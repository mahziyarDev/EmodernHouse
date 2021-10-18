using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Wallet;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IWalletService :IAsyncDisposable
    {
        Task AddWallet(SellerWallet wallet);
    }
}