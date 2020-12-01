namespace TextProcess.Infrastructure.Web.WebApp
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using SICOCC.Infrastructure.Web.WebApp;
    using TextProcess.Infrastructure.Web.API;

    public class WebStartup
    {
        private readonly IConfiguration _configuration;

        public WebStartup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureWebApp(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureWeb(env);
        }
    }
}
