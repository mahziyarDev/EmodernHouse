using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace EModernHouse.DataLayer.DTOs.UserPanel
{
    public class UserPanelIndexDTO
    {
        /// <summary>برای ثبت و یرایش ادرس</summary>
        public UserPanelManageDTO Manage { get; set; }

        /// <summary>ایا کاربر ادرس دارد ؟</summary>
        public bool IsUserAddress { get; set; }

        /// <summary>برای ادرس ایمیل</summary>
        public string Email { get; set; }

        /// <summary>برای موبایل کاربر</summary>
        public string Mobile { get; set; }

    }
}