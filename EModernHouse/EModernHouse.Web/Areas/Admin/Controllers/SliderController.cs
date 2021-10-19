using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Site;
using EModernHouse.Web.Http;
using Microsoft.AspNetCore.Http;

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

        #region CreateSlider

        [HttpGet("create-slider")]
        public async Task<IActionResult> CreateSlider()
        {
            return View();
        }

        [HttpPost("create-slider")]
        public async Task<IActionResult> CreateSlider(CreateSliderDTO slider, IFormFile sliderImage)
        {
            if (ModelState.IsValid)
            {
                if (sliderImage != null && sliderImage.IsImage())
                {
                    var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(sliderImage.FileName);
                    sliderImage.AddImageToServer(imageName,PathExtensions.SliderOriginServer,100,100,PathExtensions.SliderThumbServer);
                    var res = await _sliderService.CreateSlider(slider,imageName);
                    if (res)
                    {
                        TempData[SuccessMessage] = "اسلایدر با موفقیت ثبت شد";
                        return RedirectToAction("SliderList");
                    }

                }
            }

            TempData[ErrorMessage] = "مقادیر خواسته شده را به درستی وارد نمایید";
            return View(slider);
        }
        #endregion

        #region EditSlider
        [HttpGet("edit-slider/{sliderId}")]
        public async Task<IActionResult> EditSlider(long sliderId)
        {
            return View(await _sliderService.GetSliderForEdit(sliderId));
        }

        [HttpPost("edit-slider/{sliderId}")]
        public async Task<IActionResult> EditSlider(EditSliderDTO edit,IFormFile sliderImage)
        {
            if (ModelState.IsValid)
            {
                
                if (sliderImage != null && sliderImage.IsImage())
                {
                    var newImage = Guid.NewGuid().ToString("N") + Path.GetExtension(sliderImage.FileName);
                    sliderImage.AddImageToServer(newImage ,PathExtensions.SliderOriginServer,100,100,PathExtensions.SliderThumbServer,edit.ImageName);
                    edit.ImageName = newImage;
                }

                var res = await _sliderService.EditSlider(edit);
                if (res)
                {
                    TempData[SuccessMessage] = "ویرایش با موفقیت انجام شد";
                    return RedirectToAction("SliderList");
                }
            }
            TempData[ErrorMessage] = "مقادیر خواسته شده را وارد نمایید";
            return View(edit);
        }
        #endregion

        #region DeleteSlider
        [HttpGet("Delete-Slider/{sliderId}")]
        public async Task<IActionResult> DeleteSlider(long sliderId)
        {
            var res = await _sliderService.DeleteSlider(sliderId);
            if (res)
            {
                TempData[SuccessMessage] = "اسلایدر با موفقیت حذف شد";
                return RedirectToAction("SliderList");
            }

            TempData[ErrorMessage] = "عملیات حذف موفقیت امیز نبود";
            return RedirectToAction("SliderList");
        }

        #endregion
    }
}
