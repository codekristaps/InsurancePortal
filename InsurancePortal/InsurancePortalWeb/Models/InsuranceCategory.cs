namespace InsurancePortalWeb.Models
{
    public class InsuranceCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
