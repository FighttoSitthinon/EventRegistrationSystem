using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;
using EventRegistrationSystem.Services.IServices;

namespace EventRegistrationSystem.Services
{
    public class RoleService : IRoleService
    {
        public readonly IRoleRepository roleRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        public RoleService(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.roleRepository = new RoleRepository(dbContext);
            this.httpContextAccessor = httpContextAccessor;
        }

        public string Create(string roleName)
        {
            Role role = new Role()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                Name = roleName.ToUpper(),
                CreatedBy = GetUserName(),
                CreatedDate = DateTime.UtcNow,
            };

            roleRepository.Create(role);
            roleRepository.Save();
            return role.Id;
        }

        public Role Find(string roleName)
        {
            roleName = roleName.ToUpper();
            return roleRepository.GetByName(roleName);
        }

        public List<Role> GetAll()
        {
            return roleRepository.List().ToList();
        }

        private string GetUserName() => httpContextAccessor != null ? httpContextAccessor.HttpContext.User.Identity.Name : string.Empty;
    }
}
