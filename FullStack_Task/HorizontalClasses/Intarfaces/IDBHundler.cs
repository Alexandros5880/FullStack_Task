using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Repositories.Interfaces;

namespace FullStack_Task.HorizontalClasses.Interfaces
{
    public interface IDBHundler
    {
        IRolesRepository Roles { get; }
        IUsersRepository Users { get; }
        IRepository<Address> Address { get; }
        IRepository<BusinessArea> BuisnessAreas { get; }
        IRepository<Salutation> Salutations { get; }
        void Dispose();
    }
}