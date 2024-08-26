using SwiftClean.Domain.Enums;
namespace SwiftClean.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public string PaymentReference { get; set; } 
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
