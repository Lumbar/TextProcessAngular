namespace TextProcess.Infrastructure.Web.API
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.SpaServices.AngularCli;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using TextProcess.Infrastructure.CrossCutting.Constants;
    using TextProcess.Infrastructure.Web.Security;

    public static class ApplicationBuilderExtensions
    {
        public static void ConfigureAPI<TProgram>(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions();
            localizationOptions.SetDefaultCulture(Constants.CultureGlobalization.CULTURE_INFO);

            app.UseAllowAllCORS();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization(localizationOptions);
            app.UseMvc();
        }

        public static void ConfigureWeb(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
//                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app
                .UseMvc(routes => { routes.MapRoute("default", "{controller}/{action=Index}/{id?}"); })
                .UseAllowAllCORS()
                .UseAuthentication()
                .UseAuthorization()
                .UseSpa(spa =>
                {
                    spa.Options.SourcePath = "ClientApp";
                    if (env.IsDevelopment()) spa.UseAngularCliServer("start");
                });
        }
    }
}
