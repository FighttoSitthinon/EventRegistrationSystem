using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService ticketService;
        private readonly IEventService eventService;
        public TicketController(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor, ILogger<TicketController> logger)
        {
            _logger = logger;
            this.ticketService = new TicketService(dbContext, httpContextAccessor);
            this.eventService = new EventService(dbContext, httpContextAccessor);
        }

        [HttpGet("GetTicketById")]
        public TicketDto Get(string Id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Id)) return null;

                var Ticket = ticketService.FindById(Id);

                return Ticket;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetTicketByTicketNumber")]
        public TicketDto GetByTicketNumber(string TicketNumber)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TicketNumber)) return null;

                var Ticket = ticketService.FindByTicketNumber(TicketNumber);

                return Ticket;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("ListTicketByEventId")]
        [Authorize(Roles = "ADMIN")]
        public IEnumerable<TicketDto> List(string EventId, int page = 1)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EventId)) return null;

                var Tickets = ticketService.List(EventId, page);

                return Tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("RegisterEvent")]
        public IActionResult Create(TicketRegisterDto model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                if (string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.PhoneNumber)) return BadRequest("Email or Phone Number is Required.");

                var Event = eventService.Find(model.EventId);
                if (Event == null) return NotFound();
                if (Event.EndDate < DateTime.UtcNow) return BadRequest("Event already expired.");

                string TicketNumber = ticketService.CreateTicket(model);
                if (string.IsNullOrWhiteSpace(TicketNumber)) return BadRequest("User already register this event");

                return Ok(TicketNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
