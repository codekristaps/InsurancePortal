using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsurancePortalWeb.Models
{
    public class Insurance
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
    }
}
