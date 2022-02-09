using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        IQueryable<T> GetAllQueryable();
        Task<T> Get(int? id);
        Task<T> Add(T entity);
        T Update(T entity);
        Task<T> Delete(int? id);
        void Dispose();
    }
}
