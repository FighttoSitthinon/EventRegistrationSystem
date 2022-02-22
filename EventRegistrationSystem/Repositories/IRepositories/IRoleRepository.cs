using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IRoleRepository : IDisposable
    {
        Role GetById(string id);
        Role GetByName(string id);
        IQueryable<Role> List();
        void Create(Role model);
        void Save();
    }
}
