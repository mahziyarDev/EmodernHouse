using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entities.Site;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class SiteService : ISiteService
    {
        #region Ctor

        private readonly IGenericRepository<SiteSetting> _siteServiceRepository;

        public SiteService(IGenericRepository<SiteSetting> siteServiceRepository)
        {
            _siteServiceRepository = siteServiceRepository;
        }
        #endregion

        #region Site Setting

        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteServiceRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s => s.IsDefault && !s.IsDelete);
        }

        #endregion

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _siteServiceRepository.DisposeAsync();
        }

        #endregion

    }
}