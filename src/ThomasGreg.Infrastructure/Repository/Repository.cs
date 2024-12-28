using Microsoft.EntityFrameworkCore;
using ThomasGreg.Domain.Interfaces.Repositories;
using ThomasGreg.Domain.Models;
using ThomasGreg.Infrastructure.Context;

namespace ThomasGreg.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChangesAsync();
        }
        public async Task RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await SaveChangesAsync();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
