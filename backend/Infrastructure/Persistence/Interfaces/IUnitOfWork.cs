namespace Infrastructure.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Declaración o Matricula de las interfaces a nivel de Repositorio
        IUserRepository User { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}