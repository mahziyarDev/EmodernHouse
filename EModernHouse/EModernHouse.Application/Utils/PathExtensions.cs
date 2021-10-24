using System;
using System.IO;

namespace EModernHouse.Application.Utils
{
    public static class PathExtensions
    {
        #region default Images

        public static string DefaultAvatar = "/images/defaults/avatar.jpg";

        #endregion

        #region UserAvatar

        public static string UserAvatarOrigin = "/Content/Images/UserAvatar/Origin/";
        public static string UserAvatarOriginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/Origin/");

        public static string UserAvatarThumb = "/Content/Images/UserAvatar/Thumb/";
        public static string UserAvatarThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/Thumb/");
        #endregion

        #region Uploader

        public static string UploadImage = "/images/Upload/";
        public static string UploadImageServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Upload/");

        #endregion

        #region Slider

        public static string SliderOrigin = "/images/main-slider/SliderOrigin/";
        public static String SliderOriginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/main-slider/SliderOrigin/");
        public static string SliderThumb = "/images/main-slider/SliderThumb/";
        public static String SliderThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/main-slider/SliderThumb/");
        #endregion

        #region Banner

        public static string BannerOrigin = "/images/banner/";

        #endregion

        #region SiteLogo
        
        public static string SiteLogoForShow = "/Content/SiteLogo/";
        public static string SiteLogoForSave = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/SiteLogo/");
        
        #endregion

        #region SupportImage

        public static string SupportImage = "/images/avatar/call-center-agent.png";

        #endregion

        #region Product

        public static string ProductImageOrigin = "/Content/Images/ProductImage/Origin/";
        public static string ProductImageOriginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/ProductImage/Origin/");

        public static string ProductImageThumb = "/Content/Images/ProductImage/Thumb/";
        public static string ProductImageThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/ProductImage/Thumb/");

        #endregion

        #region productGallery
        public static string ProductGalleryImageOrigin = "/Content/Images/ProductGallery/Origin/";
        public static string ProductGalleryImageOriginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/ProductGallery/Origin/");

        public static string ProductGalleryImageThumb = "/Content/Images/ProductGallery/Thumb/";
        public static string ProductGalleryImageThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/ProductGallery/Thumb/");

        #endregion

        #region Categories

        public static string CategoryImageImageOrigin = "/Content/Images/CategoryImage/Origin/";
        public static string CategoryImageImageOriginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/CategoryImage/Origin/");

        public static string CategoryImageImageThumb = "/Content/Images/CategoryImage/Thumb/";
        public static string CategoryImageImageThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/CategoryImage/Thumb/");

        #endregion
    }
}