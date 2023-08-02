using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly PersistenceContext _persistenceContext;

        public UserRepository(PersistenceContext persistenceContext) : base(persistenceContext)
        {
            _persistenceContext = persistenceContext;
        }

        public async Task<User> AccountByUserName(string userName)
        {
            var account = await _persistenceContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.UserName!.Equals(userName));

            return account!;
        }
    }
}
