﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Common;
using EModernHouse.DataLayer.Entities.Contacts;
using EModernHouse.DataLayer.Entities.Discount;
using EModernHouse.DataLayer.Entities.Interest;
using EModernHouse.DataLayer.Entities.ProductOrder;
using EModernHouse.DataLayer.Entities.Roles;

namespace EModernHouse.DataLayer.Entities.Account
{
    public class User : BaseEntity  
    {
        #region properties

        [Display(Name = "ایمیل")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string EmailActiveCode { get; set; }

        [Display(Name = "ایمیل فعال / غیر فعال")]
        public bool IsEmailActive { get; set; }

        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Mobile { get; set; }

        
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string MobileActiveCode { get; set; }

        [Display(Name = "موبایل فعال / غیر فعال")]
        public bool IsMobileActive { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Password { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string LastName { get; set; }

        [Display(Name = "تصویر اواتار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Avatar { get; set; }

        [Display(Name = "بلاک شده / نشده")]
        public bool IsBlocked { get; set; }
        #endregion

        #region relations

        public ICollection<ContactUs> ContactUses { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<TicketMessage> TicketMessages { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductInterest> ProductInterests { get; set; }
        public UserAddress UserAddress { get; set; }
        public ICollection<ProductDiscountUse> ProductDiscountUses { get; set; }
        public ICollection<ProductComment.ProductComment> ProductComments { get; set; }
        public ICollection<UserSelectedRole> UserSelectedRoles { get; set; }
        #endregion

    }
}