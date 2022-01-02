using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Project
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
            services.AddDistributedMemoryCache(); // lưu vào ram
            services.AddSession((option) =>
            {
                option.Cookie.Name = "Cookie";
                option.IdleTimeout = new TimeSpan(0, 30, 0);
            });
            services.AddDbContext<Models.DataBasePhatTrienWebContext>(options =>
              options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();
            //bổ sung => nếu không thêm kh báo lỗi và cũg kh hiện lên
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                // thêm để chạy register

                endpoints.MapGet("/home", async (context) =>
                {
                     int? count;
                     count = context.Session.GetInt32("count");
                     if (count == null)
                     {
                         count = 0;
                     }
                     count += 1;
                     context.Session.SetInt32("count", count.Value);
                     await context.Response.WriteAsync($"So lan truy cap Read Write Session lap lai la: {count}");
                });
            });
        }
    }
}
