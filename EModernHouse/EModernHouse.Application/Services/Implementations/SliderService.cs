using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
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

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _sliderRepository.DisposeAsync();
        }

        #endregion


    }
}