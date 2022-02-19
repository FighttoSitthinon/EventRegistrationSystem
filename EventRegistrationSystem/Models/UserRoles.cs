using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class UserRoles
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
