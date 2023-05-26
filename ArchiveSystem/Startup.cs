using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using ArchiveSystem.Data;

namespace ArchiveSystem
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
            services.AddSingleton<ArchiveContext>(); // Register Archive2Context as a singleton service
            services.AddControllersWithViews(); // Add MVC controllers and views
            services.AddCors(); // Add CORS support
            services.AddControllersWithViews(); // Add MVC controllers and views
            services.AddSession(
                options => {
                    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session idle timeout to 30 minutes
                    options.Cookie.HttpOnly = true; // Set session cookie as HttpOnly
                    options.Cookie.IsEssential = true; // Mark session cookie as essential
                }
            );

            // Authorization
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.Cookie.Name = "YourCookieName";
                   options.LoginPath = "/Account/Login"; // The path for the login page
                   options.AccessDeniedPath = "/Account/AccessDenied"; // The path for the access denied page
               });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy =>
                    policy.RequireRole("Admin"));
            });

            services.AddAuthorization();
        
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
            app.UseStaticFiles(); // Serve static files

            app.UseSession(); // Enable session support
            app.UseRouting(); // Enable routing
            app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()); // Allow cross-origin requests
            app.UseAuthorization(); // Enable authorization

            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Login}/{id?}");
                });
            app.UseAuthentication();
        }
    }
}


