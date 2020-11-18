namespace api.Entities
{
    public class InventoryRecordDetail : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int InventoryRecordId { get; set; }
        public double ActualQuantity { get; set; }
        public double OldQuantity { get; set; }
        public Product Product { get; set; }
        public InventoryRecordForm InventoryRecordForm { get; set; }
    }
}