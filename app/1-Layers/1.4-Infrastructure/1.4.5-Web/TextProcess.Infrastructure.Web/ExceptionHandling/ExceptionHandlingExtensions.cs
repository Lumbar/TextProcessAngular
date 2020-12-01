namespace TextProcess.Infrastructure.Web.ExceptionHandling
{
    using Microsoft.Extensions.DependencyInjection;

    public static class ExceptionHandlingExtensions
    {
        public static IServiceCollection AddExceptionHandling(this IServiceCollection services)
        {
            services.AddScoped<ApiExceptionFilter>();

            return services;
        }
    }
}
