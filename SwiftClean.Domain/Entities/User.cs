using SwiftClean.Domain.Enums;
namespace SwiftClean.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}

