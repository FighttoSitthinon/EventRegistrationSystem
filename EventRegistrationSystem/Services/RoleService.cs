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
        public RoleService(ApplicationDbContext dbContext)
        {
            this.roleRepository = new RoleRepository(dbContext);
        }

        public string Create(string roleName)
        {
            Role role = new Role()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                Name = roleName.ToUpper(),
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
    }
}
