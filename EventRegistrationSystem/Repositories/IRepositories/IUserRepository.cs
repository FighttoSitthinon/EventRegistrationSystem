using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IUserRepository : IDisposable
    {
        User Get(string id);
        void Create(User model);
        void Update(User model);
        void Save();
    }
}
