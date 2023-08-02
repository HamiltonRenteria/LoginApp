using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Interfaces;

namespace Infrastructure.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PersistenceContext _persistenceContext;
        public IUserRepository User { get; private set; }

        public UnitOfWork(PersistenceContext persistenceContext)
        {
            _persistenceContext = persistenceContext;
            User = new UserRepository(_persistenceContext);
        }

        public void Dispose()
        {
            _persistenceContext.Dispose();
        }

        public void SaveChanges()
        {
            _persistenceContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _persistenceContext.SaveChangesAsync();
        }
    }
}