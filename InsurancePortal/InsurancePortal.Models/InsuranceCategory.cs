using System.ComponentModel.DataAnnotations;

namespace InsurancePortal.Models
{
    public class InsuranceCategory
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } // E.g., "Health", "Auto", "Home"
    }

}
