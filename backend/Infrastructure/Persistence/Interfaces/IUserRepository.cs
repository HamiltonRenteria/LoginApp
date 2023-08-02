using Domain.Entities;

namespace Infrastructure.Persistence.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> AccountByUserName(string userName);
    }
}
