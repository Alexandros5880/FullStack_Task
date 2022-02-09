using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Repositories.Interfaces;
using FullStack_Task.HorizontalClasses.Interfaces;
using System;

namespace FullStack_Task.HorizontalClasses
{
    public class DBHundler : IDisposable, IDBHundler
    {
        public IRolesRepository Roles { get; protected set; }
        public IUsersRepository Users { get; protected set; }
        public IRepository<Address> Address { get; protected set; }
        public IRepository<BusinessArea> BuisnessAreas { get; protected set; }
        public IRepository<Salutation> Salutations { get; protected set; }
        private bool disposedValue;

        public DBHundler(
                IRolesRepository roles,
                IUsersRepository users,
                IRepository<Address> address,
                IRepository<BusinessArea> bareas,
                IRepository<Salutation> salutations
            )
        {
            this.Roles = roles;
            this.Users = users;
            this.Address = address;
            this.BuisnessAreas = bareas;
            this.Salutations = salutations;
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
