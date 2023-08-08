using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Interfaces;

namespace Infrastructure.Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly PersistenceContext _persistenceContext;

        public GenericRepository(PersistenceContext persistenceContext)
        {
            _persistenceContext = persistenceContext;
        }

        public async Task<bool> RegisterAsync(T entity)
        {
            entity.AuditCreateUser = 1;
            entity.AuditCreateDate = DateTime.Now;

            _ = await _persistenceContext.AddAsync(entity);

            int recordAffected = await _persistenceContext.SaveChangesAsync();
            return recordAffected > 0;
        }
    }
}