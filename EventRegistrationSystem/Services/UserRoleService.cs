using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;
using EventRegistrationSystem.Services.IServices;

namespace EventRegistrationSystem.Services
{
    public class UserRoleService: IUserRoleService
    {
        public readonly IUserRoleRepository userRoleRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserRoleService(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.userRoleRepository = new UserRoleRepository(dbContext);
            this.httpContextAccessor = httpContextAccessor;
        }

        public string AddRole(string UserId, string RoleId)
        {
            bool IsDuplicate = userRoleRepository.IsDuplicateUserRole(UserId, RoleId);
            if (IsDuplicate) return String.Empty;

            UserRole model = new UserRole()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                RoleId = RoleId,
                UserId = UserId,
                Status = (int)Status.Active,
                CreatedBy = GetUserName(),
                CreatedDate = DateTime.UtcNow,
                UpdatedBy = GetUserName(),
                UpdatedDate = DateTime.UtcNow,
            };

            userRoleRepository.Create(model);
            userRoleRepository.Save();

            return model.Id;
        }

        private string GetUserName() => httpContextAccessor != null ? httpContextAccessor.HttpContext.User.Identity.Name : string.Empty;
    }
}
