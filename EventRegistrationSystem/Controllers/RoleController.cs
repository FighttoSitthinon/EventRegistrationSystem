using EventRegistrationSystem.Data;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public IActionResult Create(string roleName)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                string id = roleService.Create(roleName);

                if (string.IsNullOrWhiteSpace(id)) throw new Exception();

                return Ok(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("GetAllRole")]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var roles = roleService.GetAll();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("AddRoleToCurrentUser")]
        [Authorize]
        public IActionResult AddRoleToCurrentUser(string id)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();

                var userName = User?.Identity?.Name;

                if (string.IsNullOrEmpty(userName)) throw new Exception();

                var roles = roleService.AddRole(id, userName);

                 if (string.IsNullOrEmpty(userName)) throw new Exception();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
