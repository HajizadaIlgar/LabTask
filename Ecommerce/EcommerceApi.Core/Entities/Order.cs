namespace EcommerceApi.Core.Entities;

public class Order : BaseEntity
{
    public DateTime OrderDate { get; set; }
    public ICollection<OrderItem>? OrderItems { get; set; }
    public decimal TotalPrice { get; set; }
}
