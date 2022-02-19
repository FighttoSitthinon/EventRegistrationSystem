using EventRegistrationSystem.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Register")]
        public string Register(UserDto model)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "Login")]
        public string Login(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
