using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EventRegistrationSystem.Repositories
{
    public class TicketRepository: ITicketRepository, IDisposable
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<Ticket> repo;
        public TicketRepository(ApplicationDbContext db)
        {
            this.context = db;
            this.repo = this.context.Tickets;
        }

        public Ticket Get(string id) => repo.Where(x => x.Id == id && x.Status == (int)Status.Active).FirstOrDefault();

        public Ticket GetByTicketNumber(string TicketNumber) => repo.Where(x => x.TicketNumber == TicketNumber && x.Status == (int)Status.Active).FirstOrDefault();

        public IQueryable<Ticket> List(string eventId) => repo.Where(x => x.Status == (int)Status.Active && x.EventId == eventId);

        public void Create(Ticket model)
        {
            model.CreatedBy = model.Email;
            model.CreatedDate = DateTime.UtcNow;
            model.UpdatedBy = model.Email;
            model.UpdatedDate = DateTime.UtcNow;
            repo.Add(model);
        }

        public void Update(Ticket model)
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
