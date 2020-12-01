namespace TextProcess.Infrastructure.Web.API
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using TextProcess.Infrastructure.Web.Configuration;

    public class APIStartup<TProgram>
    {
        private readonly IConfiguration _configuration;

        public APIStartup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureWithoutAuthentication(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureAPI<TProgram>(env);
        }
    }

    public class APIStartup<TProgram, TDependenciesConfiguration>
        where TDependenciesConfiguration : class, IDependenciesConfiguration, new()
    {
        private readonly IConfiguration _configuration;
        private readonly TDependenciesConfiguration _dependenciesConfiguration;

        public APIStartup(IConfiguration configuration)
        {
            _configuration = configuration;
            _dependenciesConfiguration = new TDependenciesConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureWithoutAuthentication(_configuration);
            _dependenciesConfiguration.Configure(services, _configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureAPI<TProgram>(env);
        }
    }
}
