using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface ISiteService : IAsyncDisposable
    {
        #region Site Setting

        Task<SiteSetting> GetDefaultSiteSetting();

        #endregion
    }
}