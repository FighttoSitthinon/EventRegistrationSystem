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

        [HttpGet("ListTicketByEventId")]
        public IEnumerable<TicketDto> List(string id, int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}
