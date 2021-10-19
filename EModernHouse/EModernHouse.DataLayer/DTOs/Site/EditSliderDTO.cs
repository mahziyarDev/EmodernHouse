namespace EModernHouse.DataLayer.DTOs.Site
{
    public class EditSliderDTO : CreateSliderDTO
    {
        public long SliderId { get; set; }
        public string ImageName { get; set; }
    }
}