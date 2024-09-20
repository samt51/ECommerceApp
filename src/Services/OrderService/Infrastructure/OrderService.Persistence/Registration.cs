using ECommerce.Shared.Abstracts.DesignPatterns.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderService.Persistence.Context;

namespace OrderService.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderDbContext>(opt =>
         opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IUnitOfWork, OrderService.Persistence.UnitOfWorks.UnitOfWork>();
        }
    }
}
