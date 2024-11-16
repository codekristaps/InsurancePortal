namespace InsurancePortalWeb.Models
{
    public class Insurance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TypeId { get; set; }
        public string PolicyNumber { get; set; }
        public decimal Premium { get; set; }
        public decimal CoverageAmount { get; set; }
        public string Description { get; set; }

        public InsuranceType Type { get; set; }
    }

}
