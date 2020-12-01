namespace SICOCC.Infrastructure.Web.WebApp
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using TextProcess.Infrastructure.Web.ExceptionHandling;
    using TextProcess.Infrastructure.Web.MVC;
    using TextProcess.Infrastructure.Web.Security;

    public static class WebAppExtensions
    {
        public static IServiceCollection ConfigureWebApp(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .AddOptions()
                .AddLogging()
                .AddCORS()
                .AddMVCSupport()
                .AddExceptionHandling()
                .AddSpaStaticFiles(config => { config.RootPath = "ClientApp/dist"; });

            return services;
        }
    }
}
