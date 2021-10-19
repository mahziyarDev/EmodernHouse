using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Site;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;


namespace EModernHouse.Application.Services.Implementations
{
    public class SliderService : ISliderService
    {
        #region Ctor
        private readonly IGenericRepository<Slider> _sliderRepository;

        public SliderService(IGenericRepository<Slider> sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }
        #endregion

        public async Task<List<Slider>> GetAllSlider()
        {
            return await _sliderRepository.GetQuery().ToListAsync();
        }

        public async Task<bool> CreateSlider(CreateSliderDTO slider, string imageName)
        {
            var newSlider = new Slider
            {
                ImageName = imageName,
                Alt = slider.Alt,
                Link = slider.Link,
                MainHeader = slider.MainHeader,
                IsActive = slider.IsActive,
            };
            await _sliderRepository.AddEntity(newSlider);
            await _sliderRepository.SaveChanges();
            return true;
        }

        public async Task<EditSliderDTO> GetSliderForEdit(long id)
        {
            var editSlider = await _sliderRepository.GetEntityById(id);
           
            return new EditSliderDTO
            {
                
                ImageName = editSlider.ImageName,
                SliderId = editSlider.Id,
                IsActive = editSlider.IsActive,
                Alt = editSlider.Alt,
                Link = editSlider.Link,
                MainHeader = editSlider.MainHeader,
                
            };
        }

        public async Task<bool> EditSlider(EditSliderDTO editSlider)
        {
            var sliderForEdit = await _sliderRepository.GetEntityById(editSlider.SliderId);
            if (sliderForEdit == null) return false;
            
            sliderForEdit.Alt = editSlider.Alt;
            sliderForEdit.ImageName = editSlider.ImageName;
            sliderForEdit.IsActive = editSlider.IsActive;
            sliderForEdit.MainHeader = editSlider.MainHeader;
            sliderForEdit.Link = editSlider.Link;

            _sliderRepository.EditEntity(sliderForEdit);
            await _sliderRepository.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteSlider(long sliderId)
        {
            var slider = await _sliderRepository.GetEntityById(sliderId);
            if (slider == null) return false;
            _sliderRepository.Delete(slider);
            await _sliderRepository.SaveChanges();
            return true;
        }
        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _sliderRepository.DisposeAsync();
        }

        #endregion


    }
}