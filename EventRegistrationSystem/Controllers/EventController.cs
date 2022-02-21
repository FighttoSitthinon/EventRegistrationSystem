using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;
        private readonly IEventService eventService;

        public EventController(ApplicationDbContext dbContext, ILogger<EventController> logger)
        {
            _logger = logger;
            this.eventService = new EventService(dbContext);
        }

        [HttpGet("ListEvent")]
        [AllowAnonymous]
        public IEnumerable<EventDto> List(int page = 1)
        {
            try
            {
                var Event = eventService.Find(page);

                return Event;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("ListByDate")] // Admin Only
        [Authorize]
        public IEnumerable<EventDto> ListByDate(int page = 1, DateTime? start = null, DateTime? end = null)
        {
            try
            {
                var Event = eventService.Find(page, start, end);

                return Event;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetEvent")]
        [Authorize]
        public EventDto Get(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id)) return null;

                var Event = eventService.Find(id);

                return Event;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("CreateEvent")]
        [Authorize]
        public string Create(CreateEventDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                string id = eventService.Create(model);

                if (string.IsNullOrWhiteSpace(id)) throw new Exception();

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateEvent")]
        [Authorize]
        public string Update(EventDto model)
        {
            try
            {
                string id = eventService.Create(model);
                if (string.IsNullOrWhiteSpace(id)) throw new Exception();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
