using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Roles
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
