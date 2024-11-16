namespace InsurancePortalWeb.Models
{
    public class InsuranceType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public InsuranceCategory Category { get; set; }
    }

}
