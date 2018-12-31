using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Temples.Repository.DataContext;
using Temples.Repository.Interface;
using Temples.Repository.Repositories;
using Temples.Services;
using Temples.Services.Interfaces;
using Temples.ViewMapper;

namespace TempleWeb
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
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(
                options =>
                {
                    options.Password.RequiredLength = 4;
                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;

                })
                 .AddEntityFrameworkStores<AppDbContext>()
                 .AddDefaultTokenProviders();

            //google auth
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //services.AddAuthentication().AddGoogle(googleOptions =>
            //{
            //    googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
            //    googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            //});


            //Add DI for transient objects
            services.AddTransient<ITempleService, TempleService>();
            services.AddTransient<IMapper, Mapper>();

            services.AddTransient<ITempleRepository, TempleRepository>();
            services.AddTransient<ITempleTypeRepository, TempleTypeRepository>();
            services.AddTransient<ITempleBlobRepository, TempleBlobRepository>();
            services.AddTransient<IDietyRepository, DietyRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IStyleRepository, StyleRepository>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //add the automapper profile
            var config = new AutoMapper.MapperConfiguration(cfg =>
                 {
                     cfg.AddProfile(new MappingProfile());
                 }
            );
            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            logger.AddConsole();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseStaticFiles();
           
            app.UseMvc();
        }
    }
}
