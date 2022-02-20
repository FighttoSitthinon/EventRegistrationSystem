using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface IEventRepository : IDisposable
    {
        IQueryable<Event> List(DateTime? start, DateTime? end);
        Event Get(string id);
        void Create (Event model);
        void Update(Event model);
        void Save();
    }
}
