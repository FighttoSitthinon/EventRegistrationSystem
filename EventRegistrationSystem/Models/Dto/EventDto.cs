using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class EventDto
    {
        public EventDto()
        {

        }

        public EventDto(Event model)
        {
            Id = model.Id;
            Name = model.Name;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            Description = model.Description;
        }

        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}