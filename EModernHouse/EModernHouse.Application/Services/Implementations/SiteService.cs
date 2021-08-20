using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Site;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class SiteService : ISiteService
    {
        #region Ctor

        private readonly IGenericRepository<SiteSetting> _siteServiceRepository;
        private readonly IGenericRepository<Slider> _slideRepository;
        private readonly IGenericRepository<SiteBanner> _siteBanneRepository;

        public SiteService(IGenericRepository<SiteSetting> siteServiceRepository, IGenericRepository<Slider> slideRepository, IGenericRepository<SiteBanner> siteBanneRepository)
        {
            _siteServiceRepository = siteServiceRepository;
            _slideRepository = slideRepository;
            _siteBanneRepository = siteBanneRepository;
        }
        #endregion

        #region Site Setting

        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteServiceRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s => s.IsDefault && !s.IsDelete);
        }

        #endregion

        #region Slider

        public async Task<List<Slider>> GetAllActiveSlider()
        {
            return await _slideRepository.GetQuery().AsQueryable()
                .Where(s => s.IsActive && !s.IsDelete).ToListAsync();
        }

        #endregion

        #region SiteBanners

        public async Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements)
        {
            return await _siteBanneRepository.GetQuery().AsQueryable()
                .Where(s => placements.Contains(s.BannerPlacement)).ToListAsync();
        }
        #endregion

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            if (_siteServiceRepository != null) await _siteServiceRepository.DisposeAsync();
            if (_slideRepository != null) await _slideRepository.DisposeAsync();
            if (_siteBanneRepository != null) await _siteBanneRepository.DisposeAsync();

        }

        #endregion

    }
}