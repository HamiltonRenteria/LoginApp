using Domain.Entities;

namespace Infrastructure.Persistence.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<bool> RegisterAsync(T entity);
    }
}
