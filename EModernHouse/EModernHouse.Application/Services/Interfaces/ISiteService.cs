using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.DTOs.Site;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface ISiteService : IAsyncDisposable
    {
        #region Site Setting

        Task<SiteSetting> GetDefaultSiteSetting();
        Task<siteSettingFilterDTO> GetSiteSetting(int pageId, int take);
        Task<bool> CreateSetting(CreateSiteSettingDTO create,string logoImage);
        Task<EditSiteSettingDTO> GetSiteSettingForEdit(long settingId);
        Task<bool> SetSiteSettingForEdit(EditSiteSettingDTO edit);
        Task<bool> DeleteSiteSetting(long settingId);
        #endregion

        #region Slider

        Task<List<Slider>> GetAllActiveSlider();

        #endregion

        #region SiteBanners

        Task<List<DataLayer.Entities.Site.SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements);
        Task<List<SiteBanner>> GetSiteBanner();
        Task<bool> CreateSiteBanner(SiteBannerDTO banner);
        Task<bool> DeleteSiteBanner(long bannerId);
        Task<EditSiteBannerDTO> EditBanner(long bannerId);
        Task<bool> EditBannerSet(EditSiteBannerDTO edit);

        #endregion
    }
}