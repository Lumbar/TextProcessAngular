using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextProcess.Application.Contracts.TextProcess.Services;
using TextProcess.Application.TextProcess.Services;
using TextProcess.Domain.Contracts.TextProcess.Services;
using TextProcess.Domain.TextProcess.Services;
using TextProcess.Infrastructure.Data.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Data.CQS.TextProcess.Query;
using TextProcess.Infrastructure.Data.Services.TextProcess.Services;
using TextProcess.Infrastructure.Web.Configuration;

namespace TextProcess.API.Infrastructure.Crosscutting
{
    public class TextProcessDependenciesConfiguration : IDependenciesConfiguration
    {
        public IServiceCollection Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ITextProcessApplicationService, TextProcessApplicationService>();
            services.AddTransient<ITextProcessDomainService, TextProcessDomainService>();
            services.AddTransient<ITextProcessDataService, TextProcessDataService>();
            services.AddTransient<ITextProcessQuery, TextProcessQuery>();

            return services;
        }
    }
}
