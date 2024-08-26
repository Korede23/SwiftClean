namespace SwiftClean.Domain.Enums
{
    public enum OrderStatus
    {
        Pending,
        PickedUp,
        InCleaning,
        OutForDelivery,
        Completed,
        Canceled
    }

    public enum UserRole
    {
        Admin,
        Employee,
        Customer
    }

    public enum NotificationType
    {
        OrderStatusUpdate,
        Promotion,
        Reminder
    }

    public enum ItemType
    {
        Clothing,
        Linen,
        Other
    }

    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        BankTransfer,
        Cash,
        MobilePayment,
        Other
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }
}
