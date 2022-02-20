using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EventRegistrationSystem.Repositories
{
    public class EventRepository: IEventRepository, IDisposable
    {
        private readonly ApplicationDbContext context;
        
        public EventRepository(ApplicationDbContext db)
        {
            this.context = db;
        }

        public Event Get(string id)
        {
            return context.Events.Where(x => x.Id == id && x.Status == (int)Status.Active).FirstOrDefault();
        }

        public IQueryable<Event> List(DateTime? start, DateTime? end)
        {
            var result = context.Events.Where(x => x.Status == (int)Status.Active);
            if (start.HasValue && end.HasValue)
            {
                result.Where(x => x.StartDate >= start && x.EndDate <= end);
            }
            return result;
        }

        public void Create(Event model)
        {
            model.CreatedBy = "Test";
            model.CreatedDate = DateTime.UtcNow;
            model.UpdatedBy = "Test";
            model.UpdatedDate = DateTime.UtcNow;
            context.Events.Add(model);
        }

        public void Update(Event model)
        {
            model.UpdatedBy = "Test";
            model.UpdatedDate = DateTime.UtcNow;
            context.Entry(model).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region DISPOSED
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
