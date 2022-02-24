using EventRegistrationSystem.Data;
using EventRegistrationSystem.Services;
using EventRegistrationSystem.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IUserRoleService userRoleService;
        public UserRoleController(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor, ILogger<RoleController> logger)
        {
            _logger = logger;
            this.userRoleService = new UserRoleService(dbContext, httpContextAccessor);
        }

        [HttpPost("AddRoleToUser")]
        [Authorize(Roles = "ADMIN")]
        public IActionResult AddRoleToUser(string UserId, string RoleId)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Fields Required");

                var roles = userRoleService.AddRole(UserId, RoleId);

                if (string.IsNullOrEmpty(roles)) return BadRequest();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
