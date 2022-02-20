using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Role
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
