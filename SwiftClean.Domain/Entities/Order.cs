using SwiftClean.Domain.Enums;
namespace SwiftClean.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public OrderStatus Status { get; set; }
        public Guid CustomerId { get; set; }
        public User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
