using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;

namespace EModernHouse.Web.Areas.Admin.Controllers
{
    public class SliderController : AdminBaseController
    {
        #region Ctor

        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        #endregion
        [HttpGet("slider-list")]
        public async Task<IActionResult> SliderList()
        {
            return View(await _sliderService.GetAllSlider());
        }

        [HttpGet("create-slider")]
        public async Task<IActionResult> CreateSlider()
        {
            return View();
        }
    }
}
