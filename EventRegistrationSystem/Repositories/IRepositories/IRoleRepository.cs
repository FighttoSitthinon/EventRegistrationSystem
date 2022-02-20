using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IRoleRepository : IDisposable
    {
        Role GetById(string id);
        Role GetByName(string id);
        void Create(Role model);
        void Save();
    }
}
