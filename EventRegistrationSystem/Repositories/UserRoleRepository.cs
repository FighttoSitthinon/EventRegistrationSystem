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

        public IQueryable<Role> ListByUserId(string UserId)
        {
            var userRoles = (
              from userRole in this.context.UserRoles 
              where userRole.UserId == UserId && userRole.Status == (int)Status.Active
              join role in this.context.Roles on userRole.RoleId equals role.Id
              select role
            );

            return userRoles;
        }

        public bool IsDuplicateUserRole(string UserId, string RoleId)
        {
            return repo.Where(x => x.UserId == UserId && x.RoleId == RoleId && x.Status == (int)Status.Active).Any();
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
