namespace EModernHouse.DataLayer.DTOs.Product
{
    public class EditProductDTO : CreateProductDTO
    {
        public long Id { get; set; }
        public string ImageNameProduct { get; set; }
    }
}