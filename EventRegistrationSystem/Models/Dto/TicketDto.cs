using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models.Dto
{
    public class TicketDto
    {
        public TicketDto()
        {

        }
        [Required]
        public string Id { get; set; }
        [Required]
        public string TicketNumber { get; set; }
        [Required]
        public string EventId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
