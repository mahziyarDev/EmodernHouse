using EModernHouse.DataLayer.Entities.Account;

namespace EModernHouse.DataLayer.DTOs.UserPanel
{
    public class UserPanelManageDTO
    {
        

        /// <summary>ادرس کاربر در این قسمت قرار دارد</summary>
        public string UserAddress { get; set; }

        /// <summary>شهر کاربر</summary>
        public Cities City { get; set; }
    }
}