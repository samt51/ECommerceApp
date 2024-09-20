using Microsoft.AspNetCore.Builder;

namespace ECommerce.Shared.AOP.Middleware.GlobalExceptions
{
    public static class ConfigureExceptionMiddleware
    {
        public static void ConfigureExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
