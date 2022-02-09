using FullStack_Task.Areas.Identity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<bool> Add(ApplicationUser entity, string password);
        Task<ApplicationUser> Delete(string id);
        void Dispose();
        Task<ApplicationUser> Get(string id);
        Task<ICollection<ApplicationUser>> GetAll();
        IQueryable<ApplicationUser> GetAllQueryable();
        Task<ApplicationUser> Update(ApplicationUser entity);
    }
}
