using EventRegistrationSystem.BusinessLogics;
using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService userService;
        public UserController(ApplicationDbContext dbContext, IConfiguration configuration, ILogger<UserController> logger)
        {
            _logger = logger;
            this.userService = new UserService(dbContext, configuration);
        }

        [HttpPost("Register")]
        public IActionResult Register(LoginDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var userId = userService.Register(model);

                if (string.IsNullOrWhiteSpace(userId)) throw new Exception();

                return Ok(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var Token = userService.Login(model);

                if (string.IsNullOrWhiteSpace(Token)) throw new Exception();

                return Ok(Token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
