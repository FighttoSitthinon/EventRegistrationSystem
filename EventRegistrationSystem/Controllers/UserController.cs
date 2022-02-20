using EventRegistrationSystem.BusinessLogics;
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
        public string Register(LoginDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var userId = userService.Register(model);

                if (string.IsNullOrWhiteSpace(userId)) throw new Exception();

                return userId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Login")]
        public string Login(LoginDto model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var Token = userService.Login(model);

                if (string.IsNullOrWhiteSpace(Token)) throw new Exception();

                return Token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Test")]
        public bool TestJWT(string JWT)
        {
            UserManagement userManagement = new UserManagement();
            var userData = userManagement.DecodeJWTToken(JWT);
            if(userData == null) return false;
            return true;
        }
    }
}
