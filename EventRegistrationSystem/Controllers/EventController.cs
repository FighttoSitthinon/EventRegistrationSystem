using EventRegistrationSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {

        private readonly ILogger<EventController> _logger;
        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "List")]
        public IEnumerable<EventDto> List()
        {
           throw new NotImplementedException();
        }

        [HttpGet(Name = "ListByDate")] // Admin Only
        public IEnumerable<EventDto> ListByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        [HttpGet(Name = "Get")]
        public EventDto Get(string id)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "Create")]
        public string Create(EventDto model)
        {
            throw new NotImplementedException();
        }
    }
}
