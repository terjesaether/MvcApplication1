using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Customers
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Kundenavn:")]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Telefon:")]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Land:")]
        public string Country { get; set; }
    }
}