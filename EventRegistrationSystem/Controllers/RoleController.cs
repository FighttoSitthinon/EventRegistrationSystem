using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        public RoleController(ILogger<RoleController> logger)
        {
            _logger = logger;
        }

        [HttpPost("CreateRole")]
        public string Create(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
