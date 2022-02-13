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
    public class SalutationRepository : IRepository<Salutation>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public SalutationRepository(IApplicationDbContext applicationDbContext)
        {
            this._context = (ApplicationDbContext)applicationDbContext;
        }

        public async Task<Salutation> Add(Salutation entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._context.Salutetions.AddAsync(entity);
            return entity;
        }

        public async Task<Salutation> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Salutetions
                                        .FirstOrDefaultAsync(s => s.ID == id);
            this._context.Salutetions.Remove(entity);
            return entity;
        }

        public async Task<Salutation> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.Salutetions
                                    .FirstOrDefaultAsync(s => s.ID == id);
        }

        public async Task<Salutation> GetEmpty(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.Salutetions
                                    .FirstOrDefaultAsync(s => s.ID == id);
        }

        public async Task<ICollection<Salutation>> GetAll()
        {
            return await this._context.Salutetions
                                        .ToListAsync();
        }

        public IQueryable<Salutation> GetAllQueryable()
        {
            return this._context.Salutetions;
        }

        public Salutation Update(Salutation entity)
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
