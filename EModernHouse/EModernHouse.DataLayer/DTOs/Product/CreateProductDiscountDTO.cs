using System;
using System.ComponentModel.DataAnnotations;

namespace EModernHouse.DataLayer.DTOs.Product
{
    public class CreateProductDiscountDTO
    {
        public long ProductId { get; set; }

        [Range(0, 100)]
        public int Percentage { get; set; }

        [Display(Name = "تاریخ اتمام تخفیف")]
        public string ExpireDate { get; set; }
    }
}