using ECommerce.Shared.Abstracts.DesignPatterns.Repository;
using ECommerce.Shared.Abstracts.DesignPatterns.UnitOfWorks;
using ECommerce.Shared.Concretes.DesignPatterns.Repository;
using OrderService.Persistence.Context;

namespace OrderService.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderDbContext _dbContext;

        public UnitOfWork(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task CommitAsync()
        {
            await _dbContext.Database.CommitTransactionAsync();
        }

        public async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();

        public void OpenTransaction()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void RollBack()
        {
            _dbContext.Database.RollbackTransaction();
        }


        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_dbContext);



        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
        {
            return new WriteRepository<T>(_dbContext);
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                var result = await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }
    }
}
