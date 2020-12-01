namespace TextProcess.Infrastructure.Web.API
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.Security.Principal;
    using TextProcess.Infrastructure.Web.ExceptionHandling;
    using TextProcess.Infrastructure.Web.MVC;
    using TextProcess.Infrastructure.Web.Security;

    public static class WebExtensions
    {
        public static IServiceCollection ConfigureWithoutAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddOptions()
                .AddCORS()
                .AddMVCSupport()
                .AddExceptionHandling();

            return services;
        }
    }
}
