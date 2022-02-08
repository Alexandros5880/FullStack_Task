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
    public class UsersRepository : IDisposable, IUsersRepository
    {
        private bool disposedValue;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public UsersRepository(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IApplicationDbContext context)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._context = (ApplicationDbContext)context;
        }

        public async Task<bool> Add(ApplicationUser entity, string password)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            entity.UserName = entity.Email;
            var result = await this._userManager.CreateAsync(entity, password);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<ApplicationUser> Delete(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var user = await this._userManager.FindByIdAsync(id);
            await this._userManager.DeleteAsync(user);
            await this._context.SaveChangesAsync();
            return user;
        }

        public async Task<ApplicationUser> Get(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await this._userManager.FindByIdAsync(id);
        }

        public async Task<ICollection<ApplicationUser>> GetAll()
        {
            return await this._userManager.Users.ToListAsync();
        }

        public IQueryable<ApplicationUser> GetAllQueryable()
        {
            return this._userManager.Users;
        }

        public async Task<ApplicationUser> Update(ApplicationUser entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var user = await this._context.Users.FirstOrDefaultAsync(u => u.Id.Equals(entity.Id));
            user.Email = entity.Email;
            user.UserName = entity.Email;
            user.PasswordHash = entity.PasswordHash;
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            this._context.Users.Attach(user);
            this._context.Entry(user).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return entity;
        }

        public async Task AddToRole(ApplicationUser user, ApplicationRole role)
        {
            //await this._userManager.AddToRoleAsync(user, role.Name);
            IdentityUserRole<string> userRole = new IdentityUserRole<string>()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
            await this._context.UserRoles.AddAsync(userRole);
            await this._context.SaveChangesAsync();
        }

        public async Task RemoveFromRole(ApplicationUser user, ApplicationRole role)
        {
            //await this._userManager.RemoveFromRoleAsync(user, role.Name);
            IdentityUserRole<string> userRole = await this._context.UserRoles
                .FirstOrDefaultAsync(r => r.RoleId.Equals(role.Id) && r.UserId.Equals(user.Id));
            this._context.UserRoles.Remove(userRole);
            await this._context.SaveChangesAsync();
        }

        public async Task<ICollection<ApplicationRole>> GetRoles(ApplicationUser user)
        {
            var rolesNames = await this._userManager.GetRolesAsync(user);
            return await this._roleManager.Roles
                                            .Where(r => rolesNames.Contains(r.Name))
                                            .ToListAsync();
        }

        public async Task<IEnumerable<ApplicationRole>> GetOtherRoles(ApplicationUser user)
        {
            var userRoles = await this.GetRoles(user);
            var usersRolesIds = userRoles.Select(r => r.Id);
            this._context.Attach(user);
            return await this._roleManager.Roles
                                            .Where(r => !usersRolesIds.Contains(r.Id))
                                            .ToListAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._userManager.Dispose();
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
