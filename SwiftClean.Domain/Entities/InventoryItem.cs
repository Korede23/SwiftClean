namespace SwiftClean.Domain.Entities
{
    public class InventoryItem : BaseEntity
    {
        public string ItemName { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
