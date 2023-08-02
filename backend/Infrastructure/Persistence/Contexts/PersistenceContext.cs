using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence.Contexts
{
    public partial class PersistenceContext : DbContext
    {
        public PersistenceContext(DbContextOptions<PersistenceContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
