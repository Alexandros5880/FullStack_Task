using FullStack_Task.Areas.Identity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Repositories.Interfaces
{
    public interface IRolesRepository
    {
        Task Add(ApplicationRole entity);
        Task<ApplicationRole> Delete(string id);
        void Dispose();
        Task<ApplicationRole> Get(string id);
        Task<ICollection<ApplicationRole>> GetAll();
        IQueryable<ApplicationRole> GetAllQueryable();
        Task<ApplicationRole> Update(ApplicationRole entity);
    }
}
