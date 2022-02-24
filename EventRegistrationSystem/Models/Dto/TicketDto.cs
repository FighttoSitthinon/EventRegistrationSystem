using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models.Dto
{
    public class TicketDto : TicketRegisterDto
    {
        public TicketDto()
        {

        }

        public TicketDto(Ticket model)
        {
            Id = model.Id;
            TicketNumber = model.TicketNumber;
            EventId = model.EventId;
            Email = model.Email;
            PhoneNumber = model.PhoneNumber;
        }

        public string Id { get; set; }
        [Required]
        public string TicketNumber { get; set; }
        [Required]
        public string EventId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class TicketRegisterDto
    {
        public TicketRegisterDto()
        {

        }

        [Required]
        public string EventId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
