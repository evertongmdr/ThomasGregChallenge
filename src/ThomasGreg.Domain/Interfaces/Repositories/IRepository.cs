using ThomasGreg.Domain.Models;

namespace ThomasGreg.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
