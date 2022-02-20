using EventRegistrationSystem.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Register")]
        public string Register(UserDto model)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Login")]
        public string Login(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
