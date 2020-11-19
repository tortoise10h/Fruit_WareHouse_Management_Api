namespace api.Entities
{
    public class ProductRemoveDetail : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ProductRemoveFormId { get; set; }
        public int ProductId { get; set; }
        public double RemovedQuantity { get; set; }
        public Product Product { get; set; }
        public ProductRemoveForm ProductRemoveForm { get; set; }
    }
}