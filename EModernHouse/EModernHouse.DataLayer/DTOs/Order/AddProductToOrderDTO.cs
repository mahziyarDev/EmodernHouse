namespace EModernHouse.DataLayer.DTOs.Order
{
    public class AddProductToOrderDTO
    {
        public long ProductId { get; set; }

        public int Count { get; set; }

        public long? ProductColorId { get; set; }
    }
}