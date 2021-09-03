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

        public static string SliderOrigin = "/images/main-slider/";

        #endregion

        #region Banner

        public static string BannerOrigin = "/images/banner/";

        #endregion

        #region SupportImage

        public static string SupportImage = "/images/avatar/call-center-agent.png";

        #endregion
    }
}