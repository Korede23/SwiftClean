using SwiftClean.Domain.Enums;
namespace SwiftClean.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public string ItemName { get; set; }
        public ItemType ItemType { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
