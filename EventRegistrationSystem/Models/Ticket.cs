using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventRegistrationSystem.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string TicketNumber { get; set; }
        [Required]
        [ForeignKey("Event")]
        public string EventId { get; set; }
        [MaxLength(150)]
        public string? Email { get; set; }
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public virtual Event Event { get; set; }

    }
}
