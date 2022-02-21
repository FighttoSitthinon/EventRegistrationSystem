using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService ticketService;
        public TicketController(ApplicationDbContext dbContext, ILogger<TicketController> logger)
        {
            _logger = logger;
            this.ticketService = new TicketService(dbContext);
        }

        [HttpGet("GetTicket")]
        public TicketDto Get(string Id)
        {
            try
            {
                var Tickets = ticketService.Find(Id);

                return Tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("ListTicketByEventId")]
        public IEnumerable<TicketDto> List(string EventId, int page = 1)
        {
            try
            {
                var Tickets = ticketService.List(EventId, page);

                return Tickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("RegisterEvent")]
        public string Create(TicketRegisterDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                if (string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.PhoneNumber)) throw new Exception("Email or Phone Number is Required.");

                string id = ticketService.CreateTicket(model);

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
