using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EventRegistrationSystem.Repositories
{
    public class RoleRepository : IRoleRepository, IDisposable
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<Role> repo;
        public RoleRepository(ApplicationDbContext db)
        {
            this.context = db;
            this.repo = this.context.Roles;
        }

        public Role GetById(string id) => repo.Where(x => x.Id == id).FirstOrDefault();

        public Role GetByName(string name) => repo.Where(x => x.Name == name).FirstOrDefault();

        public IQueryable<Role> List()
        {
            var result = repo;
            return result;
        }

        public void Create(Role model)
        {
            repo.Add(model);
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
