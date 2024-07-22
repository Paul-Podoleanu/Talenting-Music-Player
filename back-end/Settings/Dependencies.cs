using back_end.DataLayer.Database;
using back_end.Repository;
using back_end.Service;
using Microsoft.EntityFrameworkCore;

namespace back_end.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder app)
        {
            app.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(app.Configuration.GetConnectionString("DefaultConnection"), o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
            });

            app.Services.AddCors(options =>
            {
                options.AddPolicy("Access-Control-Allow-Origin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials();
                    });
            });
            AddRepositories(app.Services);  
            AddServices(app.Services);
        }

        public static void AddRepositories(IServiceCollection repository)
        {
            repository.AddScoped<UnitOfWork>();
            repository.AddScoped<ArtistRepository>();
            repository.AddScoped<AlbumRepository>();
            repository.AddScoped<MusicFileRepository>();
        }
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ArtistService>();
            services.AddScoped<AlbumService>();
            services.AddScoped<MusicFileService>();
        }
    }
}
