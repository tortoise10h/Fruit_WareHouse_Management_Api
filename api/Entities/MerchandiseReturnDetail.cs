namespace api.Entities
{
    public class MerchandiseReturnDetail : BaseEntity
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double QuantityReturned { get; set; }
        public string Description { get; set; }
        public int MerchandiseReturnProposalId { get; set; }
        public MerchandiseReturnProposal MerchandiseReturnProposal { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}