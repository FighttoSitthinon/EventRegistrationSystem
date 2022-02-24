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
        public RoleController(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor, ILogger<RoleController> logger)
        {
            _logger = logger;
            this.roleService = new RoleService(dbContext, httpContextAccessor);
        }

        [HttpPost("CreateRole")]
        [Authorize]
        public IActionResult Create(string roleName)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                string id = roleService.Create(roleName);

                if (string.IsNullOrWhiteSpace(id)) return BadRequest();

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
                var roles = roleService.GetAll();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
