using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EventRegistrationSystem.Repositories
{
    public class UserRoleRepository: IUserRoleRepository, IDisposable
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<UserRole> repo;
        public UserRoleRepository(ApplicationDbContext db)
        {
            this.context = db;
            this.repo = this.context.UserRoles;
        }

        public UserRole GetById(string id) => repo.Where(x => x.Id == id && x.Status == (int)Status.Active).FirstOrDefault();

        public IQueryable<UserRole> ListByUserId(string UserId)
        {
            var userRoles = repo.Where(x => x.UserId == UserId && x.Status == (int)Status.Active);
            return userRoles;
        }

        public void Create(UserRole model)
        {
            model.CreatedBy = "";
            model.CreatedDate = DateTime.UtcNow;
            model.UpdatedBy = "";
            model.UpdatedDate = DateTime.UtcNow;
            repo.Add(model);
        }

        public void Update(UserRole model)
        {
            model.UpdatedBy = "";
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
