using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.DTOs.Site;
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

        public async Task<siteSettingFilterDTO> GetSiteSetting(int pageId, int take)
        {
            var siteSettings = _siteServiceRepository.GetQuery().AsQueryable();
            //for filter
            var skip = (pageId - 1) * take;

            var model = new siteSettingFilterDTO
            {
                SiteSettings = await siteSettings.Skip(skip).Take(take).ToListAsync(),
            };
            model.GeneratePaging(siteSettings,pageId,take);
            return model;
        }

        public async Task<bool> CreateSetting(CreateSiteSettingDTO create, string logoImage)
        {
            
            var newSiteSetting = new SiteSetting
            {
                CopyRight = create.CopyRight,
                Logo = logoImage,
                Mobile = create.Mobile,
                Phone = create.Phone,
                Email = create.Email,
                IsDefault = create.IsActive,
                IsDelete = false
            };

            await _siteServiceRepository.AddEntity(newSiteSetting);
            await _siteServiceRepository.SaveChanges();
            return true;
        }

        public async Task<EditSiteSettingDTO> GetSiteSettingForEdit(long settingId)
        {
            var siteSetting = await _siteServiceRepository.GetEntityById(settingId);

            return new EditSiteSettingDTO
            {
                SiteSettingId = siteSetting.Id,
                LogoImage = siteSetting.Logo,
                Mobile = siteSetting.Mobile,
                Email = siteSetting.Email,
                Phone = siteSetting.Phone,
                IsActive = siteSetting.IsDefault,
                CopyRight = siteSetting.CopyRight
            };
        }
        
        public async Task<bool> SetSiteSettingForEdit(EditSiteSettingDTO edit)
        {
            var siteSetting = await _siteServiceRepository.GetEntityById(edit.SiteSettingId);
            if (siteSetting == null) return false;
            siteSetting.CopyRight = edit.CopyRight;
            siteSetting.Mobile = edit.Mobile;
            siteSetting.Email = edit.Email;
            siteSetting.Phone = edit.Phone;
            siteSetting.Logo = edit.LogoImage;
            siteSetting.IsDefault = edit.IsActive;
            _siteServiceRepository.EditEntity(siteSetting);
            await _siteServiceRepository.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteSiteSetting(long settingId)
        {
            var setting = await _siteServiceRepository.GetEntityById(settingId);
            if (setting == null) return false;
            _siteServiceRepository.Delete(setting);
            await _siteServiceRepository.SaveChanges();
            return true;
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