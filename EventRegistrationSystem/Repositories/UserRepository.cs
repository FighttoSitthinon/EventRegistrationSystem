using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EventRegistrationSystem.Repositories
{
    public class UserRepository: IUserRepository, IDisposable
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<User>  repo;
        public UserRepository(ApplicationDbContext db)
        {
            this.context = db;
            this.repo = this.context.Users;
        }

        public User Get(string id) => repo.Where(x => x.Id == id && x.Status == (int)Status.Active).FirstOrDefault();

        public void Create(User model)
        {
            model.CreatedBy = "Test";
            model.CreatedDate = DateTime.UtcNow;
            model.UpdatedBy = "Test";
            model.UpdatedDate = DateTime.UtcNow;
            repo.Add(model);
        }

        public void Update(User model)
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
