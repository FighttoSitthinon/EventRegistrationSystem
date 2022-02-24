using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;
using EventRegistrationSystem.Services.IServices;

namespace EventRegistrationSystem.Services
{
    public class EventService: IEventService
    {
        public readonly IEventRepository eventRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public EventService(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.eventRepository = new EventRepository(dbContext);
            this.httpContextAccessor = httpContextAccessor;
        }

        public EventDto Find(string id)
        {
            var result = eventRepository.Get(id);
            if (result == null) return null;

            return new EventDto(result);
        }

        public PagedList<EventDto> Find(int page = 1, DateTime? start = null, DateTime? end = null)
        {
            int pageSize = 12;

            var query = eventRepository.List(start, end).Select(x => new EventDto(x));
            if (query == null) return null;

            return PagedList<EventDto>.ToPagedList(query, page, pageSize);
        }

        public string Create(CreateEventDto model)
        {
            Event Event = new Event()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Name = model.Name,
                Description = model.Description,
                Status = (int)Status.Active,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                CreatedBy = GetUserName(),
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = GetUserName(),
                UpdatedDate = DateTime.UtcNow
            };

            eventRepository.Create(Event);
            eventRepository.Save();
            return Event.Id;
        }

        public string Update(EventDto model)
        {
            var Event = eventRepository.Get(model.Id);
            if (Event == null) return string.Empty;

            Event.StartDate = model.StartDate;
            Event.EndDate = model.EndDate;
            Event.Name = model.Name;
            Event.Description = model.Description;
            Event.Latitude = model.Latitude;
            Event.Longitude = model.Longitude;
            Event.UpdatedBy = GetUserName();
            Event.UpdatedDate = DateTime.UtcNow;
            eventRepository.Update(Event);
            eventRepository.Save();

            return Event.Id;
        }

        private string GetUserName() => httpContextAccessor != null ? httpContextAccessor.HttpContext.User.Identity.Name : string.Empty;
    }
}
