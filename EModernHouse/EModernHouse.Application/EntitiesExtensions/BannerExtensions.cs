using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.Application.EntitiesExtensions
{
    public static class BannerExtensions
    {
        public static string GetBannerMainImageAddress(this SiteBanner banner)
        {
            return PathExtensions.BannerOrigin + banner.ImageName;
        }
    }
}