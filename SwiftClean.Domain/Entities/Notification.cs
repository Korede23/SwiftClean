using SwiftClean.Domain.Enums;
namespace SwiftClean.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public NotificationType Type { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
