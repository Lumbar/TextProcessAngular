namespace TextProcess.Infrastructure.Web.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public interface IDependenciesConfiguration
    {
        IServiceCollection Configure(IServiceCollection services, IConfiguration configuration);
    }
}
