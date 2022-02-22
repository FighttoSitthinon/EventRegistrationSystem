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
        public readonly IUserRoleRepository userRoleRepository;
        public readonly IUserRepository userRepository;
        public RoleService(ApplicationDbContext dbContext)
        {
            this.roleRepository = new RoleRepository(dbContext);
            this.userRoleRepository = new UserRoleRepository(dbContext);
            this.userRepository = new UserRepository(dbContext);
        }

        public string AddRole(string roleId, string UserName)
        {
            var user = userRepository.GetByEmail(UserName);
            if (user == null) return String.Empty;

            UserRole model = new UserRole()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                RoleId = roleId,
                UserId = user.Id,
                Status = (int)Status.Active,
            };

            bool IsDuplicate = userRoleRepository.IsDuplicateUserRole(model.UserId, model.RoleId);
            if (IsDuplicate) return String.Empty;

            userRoleRepository.Create(model);
            roleRepository.Save();

            return model.Id;
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

        public List<Role> GetAll()
        {
            return roleRepository.List().ToList();
        }
    }
}
