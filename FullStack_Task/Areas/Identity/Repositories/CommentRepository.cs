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
    public class CommentRepository : IRepository<Comment>, IDisposable
    {
        private bool disposedValue;
        private readonly ApplicationDbContext _context;

        public CommentRepository(IApplicationDbContext applicationDbContext)
        {
            this._context = (ApplicationDbContext)applicationDbContext;
        }

        public async Task<Comment> Add(Comment entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await this._context.Comments.AddAsync(entity);
            return entity;
        }

        public async Task<Comment> Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            var entity = await this._context.Comments
                            .FirstOrDefaultAsync(c => c.ID == id);
            this._context.Comments.Remove(entity);
            return entity;
        }

        public async Task<Comment> Get(int? id)
        {
            return await this._context.Comments
                        .Include(c => c.User)
                        .FirstOrDefaultAsync(c => c.ID == id);
        }

        public async Task<ICollection<Comment>> GetAll()
        {
            return await this._context.Comments
                            .Include(c => c.User)
                            .ToListAsync();
        }

        public IQueryable<Comment> GetAllQueryable()
        {
            return this._context.Comments;
        }

        public Comment Update(Comment entity)
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
