﻿namespace TextProcess.Infrastructure.Web.Security
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public static class CORSExtensions
    {
        public static IServiceCollection AddCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllCORS",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                        //.AllowCredentials();
                    });
            });


            return services;
        }
        public static IApplicationBuilder UseAllowAllCORS(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            return app.UseCors("AllowAllCORS");
        }
    }
}
