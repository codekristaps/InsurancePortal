using System.ComponentModel.DataAnnotations;

namespace InsurancePortal.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

}
