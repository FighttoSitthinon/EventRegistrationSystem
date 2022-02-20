using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IUserRepository : IDisposable
    {
        User Get(string id);
        User GetByEmail(string email);
        bool IsUserExisted(string email);
        void Create(User model);
        void Update(User model);
        void Save();
    }
}
