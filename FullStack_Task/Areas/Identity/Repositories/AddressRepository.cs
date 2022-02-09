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
    public class AddressRepository : IRepository<Address>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public AddressRepository(IApplicationDbContext applicationDbContext)
        {
            this._context = (ApplicationDbContext)applicationDbContext;
        }

        public async Task<Address> Add(Address entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._context.Addresses.AddAsync(entity);
            return entity;
        }

        public async Task<Address> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Addresses
                .FirstOrDefaultAsync(a => a.ID == id);
            this._context.Addresses.Remove(entity);
            return entity;
        }

        public async Task<Address> Get(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._context.Addresses
                    .Include(d => d.User)
                    .FirstOrDefaultAsync(a => a.ID == id);
        }

        public async Task<ICollection<Address>> GetAll()
        {
            return await this._context.Addresses
                                    .ToListAsync();
        }

        public IQueryable<Address> GetAllQueryable()
        {
            return this._context.Addresses;
        }

        public Address Update(Address entity)
        {
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
