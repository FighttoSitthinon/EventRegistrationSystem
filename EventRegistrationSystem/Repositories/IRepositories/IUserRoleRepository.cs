using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IUserRoleRepository: IDisposable
    {
        IQueryable<string> ListRolesByUserId(string UserId);
        UserRole GetById(string id);
        bool IsDuplicateUserRole(string UserId, string RoleId);
        void Create(UserRole model);
        void Update(UserRole model);
        void Save();
    }
}
