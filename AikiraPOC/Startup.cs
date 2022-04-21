using AikiraPOC_Core.Interfaces.Persistence;
using AikiraPOC_Infrastructure.CosmosDbData.Repository;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
[assembly: FunctionsStartup(typeof(AikiraPOC_AzureFunctions.Startup))]
namespace AikiraPOC_AzureFunctions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configurations
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();        
            services.AddSingleton<IConfiguration>(configuration);          
           // string Connstr = Environment.GetEnvironmentVariable("ConnectionStrings:TestAikiraConnection");
            services.AddScoped<IFileInfoRepository, FileInfoRepository>();
        }
    }
}
