using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService userService;
        public UserController(ApplicationDbContext dbContext, ILogger<UserController> logger)
        {
            _logger = logger;
            this.userService = new UserService(dbContext);
        }

        [HttpPost("Register")]
        public string Register(UserDto model)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Login")]
        public string Login(LoginDto model)
        {
            throw new NotImplementedException();
        }
    }
}
