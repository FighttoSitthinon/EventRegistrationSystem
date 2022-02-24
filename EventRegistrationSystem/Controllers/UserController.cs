using EventRegistrationSystem.BusinessLogics;
using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models.Dto;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

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
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                /*
                    At least one upper case English letter, (?=.*?[A-Z])
                    At least one lower case English letter, (?=.*?[a-z])
                    At least one digit, (?=.*?[0-9])
                    At least one special character, (?=.*?[#?!@$%^&*-])
                    Minimum eight in length .{8,} (with the anchors)
                */
                string strRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
                Regex re = new Regex(strRegex);

                if (!re.IsMatch(model.Password)) return BadRequest("Password must contains A-Z, a-z, 0-9, special character and minimum 8 in length.");

                var userId = userService.Register(model);

                if (string.IsNullOrWhiteSpace(userId)) return BadRequest("User already exist.");

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
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                var Token = userService.Login(model);

                if (string.IsNullOrWhiteSpace(Token)) return BadRequest("User Email or Password is mismatch.");

                return Ok(Token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
