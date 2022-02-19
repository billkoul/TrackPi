using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVVMDataLayer;
using MVVMViewModelLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

namespace trackpi
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
            services.AddControllersWithViews();

            services.AddDistributedMemoryCache();

            services.AddRazorPages();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromDays(60);
                options.Cookie.IsEssential = true;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "Track-PiCookie";
                //options.Cookie.HttpOnly = true;
                //options.Cookie.IsEssential = false;
                options.ExpireTimeSpan = TimeSpan.FromDays(60);
                options.LoginPath = "/login/";
                options.LogoutPath = "/logout/";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

            services.AddAntiforgery(options => options.HeaderName = "RequestVerificationToken");

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/{0}.cshtml");
            });

            services.AddMvc(option => option.EnableEndpointRouting = false).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Culture = new CultureInfo("en-US");
            });


            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Culture = new CultureInfo("en-US");
            });
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Culture = new CultureInfo("en-US");
            });
            services.AddRazorPages().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Culture = new CultureInfo("en-US");
            });

            services.AddHttpContextAccessor();

            InjectAppServices(services);
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

            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions
            {
                ServeUnknownFileTypes = true
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }

        private void InjectAppServices(IServiceCollection services)
        {
            // Get connection string from appsettings.json  
            string cnn = Configuration["ConnectionStrings:Default"];

            // Add AdventureWorks DbContext object  
            services.AddDbContext<AdvWorksDbContext>(options => options.UseMySql(cnn, ServerVersion.AutoDetect(cnn)));

            // Add Classes for Scoped DI  
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<LocationViewModel>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserViewModel>();
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
            services.AddScoped<SubscriptionViewModel>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<DeviceViewModel>();
        }
    }
}
