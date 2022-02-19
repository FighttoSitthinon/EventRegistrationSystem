using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        public RoleController(ILogger<RoleController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Create")]
        public string Create(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
