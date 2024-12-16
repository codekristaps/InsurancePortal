using System.ComponentModel.DataAnnotations;

namespace InsurancePortal.Models
{
    public class Insurance
    {
        [Key]
        public Guid InsuranceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, 1000)]
        public decimal Price { get; set; }
    }
}
