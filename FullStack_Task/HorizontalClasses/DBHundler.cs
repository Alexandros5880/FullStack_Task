using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Repositories.Interfaces;
using FullStack_Task.Data;
using FullStack_Task.HorizontalClasses.Interfaces;
using System;
using System.Threading.Tasks;

namespace FullStack_Task.HorizontalClasses
{
    public class DBHundler : IDisposable, IDBHundler
    {
        public IRolesRepository Roles { get; protected set; }
        public IUsersRepository Users { get; protected set; }
        public IRepository<Address> Address { get; protected set; }
        public IRepository<BusinessArea> BuisnessAreas { get; protected set; }
        public IRepository<Salutation> Salutations { get; protected set; }
        public IRepository<Comment> Comments { get; protected set; }
        private readonly ApplicationDbContext _context;

        private bool disposedValue;

        public DBHundler(
                IRolesRepository roles,
                IUsersRepository users,
                IRepository<Address> address,
                IRepository<BusinessArea> bareas,
                IRepository<Salutation> salutations,
                IRepository<Comment> comments,
                IApplicationDbContext applicationDbContext
            )
        {
            this.Roles = roles;
            this.Users = users;
            this.Address = address;
            this.BuisnessAreas = bareas;
            this.Salutations = salutations;
            this.Comments = comments;
            this._context = (ApplicationDbContext)applicationDbContext;
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Roles.Dispose();
                    this.Users.Dispose();
                    this.Address.Dispose();
                    this.BuisnessAreas.Dispose();
                    this.Salutations.Dispose();
                    this.Comments.Dispose();
                    this._context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
