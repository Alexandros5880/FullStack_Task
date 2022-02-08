using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Repositories.Interfaces;
using FullStack_Task.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Repositories
{
    public class RolesRepository : IRolesRepository, IDisposable
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private bool disposedValue;

        public RolesRepository(RoleManager<ApplicationRole> roleManager, IApplicationDbContext context)
        {
            this._roleManager = roleManager;
            this._context = (ApplicationDbContext)context;
        }

        public async Task<ICollection<ApplicationRole>> GetAll()
        {
            return await this._roleManager.Roles.ToListAsync();
        }

        public IQueryable<ApplicationRole> GetAllQueryable()
        {
            return this._roleManager.Roles;
        }

        public async Task<ApplicationRole> Get(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var role = await this._roleManager.FindByIdAsync(id);
            return role;
        }

        public async Task Add(ApplicationRole entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._roleManager.CreateAsync(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task<ApplicationRole> Update(ApplicationRole entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var role = await this._context.Roles.FirstOrDefaultAsync(r => r.Id.Equals(entity.Id));
            role.Name = entity.Name;
            role.NormalizedName = entity.Name.ToUpper();
            this._context.Roles.Attach(role);
            this._context.Entry(role).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return entity;
        }

        public async Task<ApplicationRole> Delete(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var role = await this._roleManager.FindByIdAsync(id);
            await this._roleManager.DeleteAsync(role);
            await this._context.SaveChangesAsync();
            return role;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._roleManager.Dispose();
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
