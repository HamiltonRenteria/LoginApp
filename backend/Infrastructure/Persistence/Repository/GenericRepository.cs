using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly PersistenceContext _persistenceContext;
        //private readonly DbSet<T> _entity;

        public GenericRepository(PersistenceContext persistenceContext)
        {
            _persistenceContext = persistenceContext;
            //_entity = _persistenceContext.Set<T>();
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
