using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface ISiteService : IAsyncDisposable
    {
        #region Site Setting

        Task<SiteSetting> GetDefaultSiteSetting();
        Task<siteSettingFilterDTO> GetSiteSetting(int pageId, int take);

        #endregion

        #region Slider

        Task<List<Slider>> GetAllActiveSlider();

        #endregion

        #region SiteBanners

        Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements);

        #endregion
    }
}