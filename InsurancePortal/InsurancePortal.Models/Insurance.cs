using InsurancePortal.Models;

public class Insurance
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CategoryId { get; set; } // Foreign key to InsuranceCategory
    public InsuranceCategory Category { get; set; } // Navigation property
    public decimal Premium { get; set; }
    public decimal CoverageAmount { get; set; }
    public string Description { get; set; }
}
