using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Data.Repo;

namespace Shop
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("dbsettings.json").Build(); ;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // репозитории
            services.AddTransient<ICategoryRepo, CategoryRepo>();
            services.AddTransient<ICarRepo, CarRepo>();
            services.AddTransient<ICartRepo, CartRepo>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // настройки соединения
            string connection = Configuration.GetConnectionString("DefaultConnection");

            // соединение с postgres
            services.AddDbContext<ApplicationContext>(
                options => options.UseNpgsql(connection));

            // MVC
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddSession();
            //services.AddMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
