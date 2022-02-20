using EventRegistrationSystem.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }

        [HttpPost("RegisterEvent")]
        public string Create(TicketDto model)
        {
            throw new NotImplementedException();
        }

        [HttpGet("ListTicketByEvent")]
        public IEnumerable<TicketDto> List(string EventId)
        {
            throw new NotImplementedException();
        }
    }
}
