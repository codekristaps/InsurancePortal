namespace InsurancePortalWeb.Models
{
    public class PolicyPurchase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public Guid InsuranceId { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Customer Customer { get; set; }
        public Insurance Insurance { get; set; }
    }

}
