using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(300)]
        public string HashPassword { get; set; }
        [Required]
        [MaxLength(300)]
        public string SaltPassword { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
