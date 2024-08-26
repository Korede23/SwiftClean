using SwiftClean.Domain.Enums;

namespace SwiftClean.Application.Dtos.RequestModel
{
    public class CreateOrder
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public OrderStatus Status { get; set; }
        public Guid CustomerId { get; set; }
    }
}
