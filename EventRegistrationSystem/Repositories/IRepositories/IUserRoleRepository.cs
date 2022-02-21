using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IUserRoleRepository: IDisposable
    {
        IQueryable<UserRole> ListByUserId(string UserId);
        UserRole GetById(string id);
        void Create(UserRole model);
        void Update(UserRole model);
        void Save();
    }
}
