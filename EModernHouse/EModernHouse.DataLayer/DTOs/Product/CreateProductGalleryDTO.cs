namespace EModernHouse.DataLayer.DTOs.Product
{
    public class CreateProductGalleryDTO
    {
        public long ProductId { get; set; }
        public int DisplayPriority { get; set; }
        public string ImageName { get; set; }
        public string Alt { get; set; }
    }
}