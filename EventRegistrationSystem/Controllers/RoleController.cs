using EventRegistrationSystem.Data;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IRoleService roleService;
        public RoleController(ApplicationDbContext dbContext, ILogger<RoleController> logger)
        {
            _logger = logger;
            this.roleService = new RoleService(dbContext);
        }

        [HttpPost("CreateRole")]
        public string Create(string roleName)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                string id = roleService.Create(roleName);

                if (string.IsNullOrWhiteSpace(id)) throw new Exception();

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
