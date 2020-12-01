namespace TextProcess.Infrastructure.Web.Configuration
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using System.Reflection;
    using TextProcess.Infrastructure.Web.API;
    using TextProcess.Infrastructure.Web.WebApp;

    public static class WebHostHelper
    {
        public static void BuildAndRunWebApp<TProgram>(string[] args) where TProgram : class
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<WebStartup>()
                .UseSetting(WebHostDefaults.ApplicationKey, typeof(TProgram).GetTypeInfo().Assembly.FullName)
                .Build()
                .Run();
        }

        public static void BuildAndRunWebAPI<TStartup>(string[] args)
            where TStartup : class
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<TStartup>()
                .Build()
                .Run();
        }

        public static void BuildAndRunWebAPI<TProgram, TDependenciesConfiguration>(string[] args)
            where TProgram : class
            where TDependenciesConfiguration : class, IDependenciesConfiguration, new()
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<APIStartup<TProgram, TDependenciesConfiguration>>()
                .UseSetting(WebHostDefaults.ApplicationKey, typeof(TProgram).GetTypeInfo().Assembly.FullName)
                .Build()
                .Run();
        }

        public static void BuildAndRunConfigurationWebAPI<TProgram, TDependenciesConfiguration>(string[] args)
            where TProgram : class
            where TDependenciesConfiguration : class, IDependenciesConfiguration, new()
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<UnsecureAPIStartup<TProgram, TDependenciesConfiguration>>()
                .UseSetting(WebHostDefaults.ApplicationKey, typeof(TProgram).GetTypeInfo().Assembly.FullName)
                .Build()
                .Run();
        }
    }
}
