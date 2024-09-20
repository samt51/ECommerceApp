using ECommerce.Shared.Abstracts.DesignPatterns.Repository;
using ECommerce.Shared.AOP.Middleware.GlobalExceptions;
using ECommerce.Shared.Concretes.DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ECommerce.Shared
{
    public static class Registration
    {
        public static IServiceCollection AddShared(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();


            services.AddTransient<ExceptionMiddleware>();

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<ECommerce.Shared.Abstracts.Mapper.IMapper, ECommerce.Shared.Concretes.Mapping.Mapper>();


            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
