using ECommerce.Shared.Abstracts.DesignPatterns.Repository;

namespace ECommerce.Shared.Abstracts.DesignPatterns.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, new();
        void OpenTransaction();
        Task<int> SaveAsync();
        Task CommitAsync();
        void RollBack();

    }
}
