using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePortalWeb.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; set; }
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
    }
}
