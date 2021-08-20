using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.Entites.Contacts;

namespace EModernHouse.Application.EntitiesExtensions
{
    public static class SliderExtensions
    {
        public static string GetSliderImageAddress(this Slider slider)
        {
            return PathExtensions.SliderOrigin + slider.ImageName;
        }
    }
}