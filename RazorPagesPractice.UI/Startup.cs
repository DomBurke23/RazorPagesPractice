using Microsoft.ApplicationInsights.WorkerService;
using RazorPagesPractice.Core.Extensions;
using RazorPagesPractice.Gateways.Extensions;

namespace RazorPagesPractice.UI
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            var instrumentationkey = Configuration["APPINSIGHTS_INSTRUMENTATIONKEY"];
            services.AddApplicationInsightsTelemetryWorkerService(
                (ApplicationInsightsServiceOptions options) => options.ConnectionString = $"InstrumentationKey={instrumentationkey}");

            services.AddLogging(logging =>
            {
                logging.AddConsole();
                logging.AddDebug();
                logging.AddAzureWebAppDiagnostics();
            });
            services.AddCoreServices();
            services.AddGatewayServices(Configuration);
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app,
            IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute("default", "{controller=Transaction}/{action=Index}/{id?}");
            });
        }
    }
}
