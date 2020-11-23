namespace api.Entities
{
    public class GoodsReceivingOfReturnDetail : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GoodsReceivingOfReturnId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public GoodsReceivingOfReturn GoodsReceivingOfReturn { get; set; }
    }
}