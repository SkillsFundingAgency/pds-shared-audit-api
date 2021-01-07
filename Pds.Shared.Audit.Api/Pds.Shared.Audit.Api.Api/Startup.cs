using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pds.Core.Logging;
using Pds.Core.Telemetry.ApplicationInsights;
using Pds.Shared.Audit.Api.Api.MvcConfiguration;
using Pds.Shared.Audit.Api.Services.DependencyInjection;

namespace Pds.Shared.Audit.Api.Api
{
    /// <summary>
    /// The startup class.
    /// </summary>
    public class Startup
    {
        private const string CurrentApiVersion = "v1.0.0";

        private static string _assemblyName;

        /// <summary>
        /// Gets the application configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        private string AssemblyName
        {
            get
            {
                if (string.IsNullOrEmpty(_assemblyName))
                {
                    _assemblyName = this.GetType().Assembly.GetName().Name;
                }

                return _assemblyName;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The application configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Configures the services for the container.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiControllers();
            services.AddFeatureServices();
            services.AddPdsApplicationInsightsTelemetry(options => BuildAppInsightsConfiguration(options));
            services.AddLoggerAdapter();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(CurrentApiVersion, new OpenApiInfo { Title = AssemblyName, Version = CurrentApiVersion });
            });
        }

        /// <summary>
        /// Configures the HTTP request pipeline.
        /// </summary>
        /// <param name="app">The application builder.</param>
        /// <param name="env">The web hosting environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/{CurrentApiVersion}/swagger.json", AssemblyName);
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void BuildAppInsightsConfiguration(PdsApplicationInsightsConfiguration options)
        {
            Configuration.Bind("PdsApplicationInsights", options);
            options.Component = AssemblyName;
        }
    }
}