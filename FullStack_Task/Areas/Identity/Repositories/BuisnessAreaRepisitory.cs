using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Repositories.Interfaces;
using FullStack_Task.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Repositories
{
    public class BuisnessAreaRepisitory : IRepository<BusinessArea>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public BuisnessAreaRepisitory(IApplicationDbContext applicationDbContext)
        {
            this._context = (ApplicationDbContext)applicationDbContext;
        }

        public async Task<BusinessArea> Add(BusinessArea entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._context.BusinessAreas.AddAsync(entity);
            return entity;
        }

        public async Task<BusinessArea> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.BusinessAreas
                                        .FirstOrDefaultAsync(b => b.ID == id);
            this._context.BusinessAreas.Remove(entity);
            return entity;
        }

        public async Task<BusinessArea> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.BusinessAreas
                            .Include(b => b.Users)
                            .FirstOrDefaultAsync(b => b.ID == id);
        }

        public async Task<BusinessArea> GetEmpty(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.BusinessAreas
                            .FirstOrDefaultAsync(b => b.ID == id);
        }

        public async Task<ICollection<BusinessArea>> GetAll()
        {
            return await this._context.BusinessAreas
                                        .Include(b => b.Users)
                                        .ToListAsync();
        }

        public IQueryable<BusinessArea> GetAllQueryable()
        {
            return this._context.BusinessAreas;
        }

        public BusinessArea Update(BusinessArea entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this._context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
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
