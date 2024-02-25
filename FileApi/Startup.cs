using Microsoft.Extensions.DependencyInjection;

namespace FileApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add services
            // services.AddScoped<IFileService, FileService>();
            services.AddControllers().AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
