using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class EventDto : CreateEventDto
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
            Latitude = model.Latitude;
            Longitude = model.Longitude;
            GoogleMapUrl = "https://www.google.com/maps/dir/Current+Location/" + Latitude + "," + Longitude;
        }

        public string Id { get; set; }
        public string GoogleMapUrl { get; set; }
    }

    public class CreateEventDto
    {
        public CreateEventDto()
        {

        }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}