namespace SwiftClean.Domain.Entities
{
    public class Report : BaseEntity
    {
        public string ReportName { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string GeneratedBy { get; set; }
        public string Data { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
