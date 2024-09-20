namespace ECommerce.Shared.Abstracts.DesignPatterns.Repository
{
    public interface IWriteRepository<T> where T : class, new()
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        void UpdateRange(IList<T> entities);
        Task<T> UpdateAsync(T entity);
    }
}
