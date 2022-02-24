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

        public EventController(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor, ILogger<EventController> logger)
        {
            this.eventService = new EventService(dbContext, httpContextAccessor);
            _logger = logger;
        }

        [HttpGet("ListEvent")]
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
        [Authorize(Roles = "ADMIN")]
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
        [Authorize(Roles = "ADMIN")]
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
        public IActionResult Create(CreateEventDto model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                string id = eventService.Create(model);

                if (string.IsNullOrWhiteSpace(id)) return BadRequest();

                return Ok(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateEvent")]
        [Authorize]
        public IActionResult Update(EventDto model)
        {
            try
            {
                string id = eventService.Update(model);

                if (string.IsNullOrWhiteSpace(id)) return BadRequest();

                return Ok(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
