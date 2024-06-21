using File_Sharing_Platform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Data.Repositories;
using MVC.VsTube.Services.Services;

namespace MVC.VsTube.Services
{
    public static class Startup
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();

            services.AddAutoMapper(typeof(Startup)); //AutoMapper

            services.AddScoped<IVideoService, VideoService>(); // Регистрация зависимостей
            services.AddScoped<IVideoRepository, VideoRepository>();

            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<ILikeService, LikeService>();

            services.AddScoped<IPlaylistRepository, PlaylistRepository>();
            services.AddScoped<IPlaylistService, PlaylistService>();

            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>(); //todo
            services.AddScoped<ISubscriptionService, SubscriptionService>();

            services.AddDbContext<YouTubeContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); // Настройка базы данных
        }
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
