namespace EcommerceApi.BL.DTOs.Order
{
    public class OrderCreateDto
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
