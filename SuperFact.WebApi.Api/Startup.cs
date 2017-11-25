using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using SuperFact.Data.Data;
using SuperFact.Helper.Host;
using System.Net;

namespace SuperFact.WebApi.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["Production:SuperFactConnection"];

            ConfigStartup.ConfigDb(services, connection);
            //Add CORS services.  
            services.AddCors(
                options => options.AddPolicy("AllowCors",
                builder =>
                {
                    builder
                    .AllowAnyOrigin() //AllowAllOrigins;                  
                    .WithMethods("GET", "PUT", "POST", "DELETE") //AllowSpecificMethods;                     
                    .AllowAnyHeader(); //AllowAllHeaders;  
                }));

            services.AddMvc(config =>
            {
                config.Filters.Add(typeof(CustomExceptionFilter));
            }).AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new DefaultContractResolver(); });
            ConfigStartup.DependecyInjection(services);

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, ISuperFactDbInitializer dbInitializer)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler(options =>
                {
                    options.Run(
                    async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "text/html";
                        var ex = context.Features.Get<IExceptionHandlerFeature>();
                        if (ex != null)
                        {
                            var err = $"<h1>Error: {ex.Error.Message}</h1>{ex.Error.StackTrace }";
                            await context.Response.WriteAsync(err).ConfigureAwait(false);
                        }
                    });
                });
            }
            app.UseStaticFiles();

            //Generate EF Core Seed Data
            dbInitializer.InitializeAsync();

            //   app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            app.UseMvc();
            //Enable CORS policy "AllowCors"  
            app.UseCors("AllowCors");

        }
    }
}
