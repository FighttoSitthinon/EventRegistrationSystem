using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.Dto;

namespace EventRegistrationSystem.Services.IServices
{
    public interface IEventService
    {
        string Create(CreateEventDto model);
        string Update(EventDto model);
        EventDto Find(string id);
        PagedList<EventDto> Find(int page = 1, DateTime? start = null, DateTime? end = null);
    }
}
