using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.PhoneBook.Business.Abstract;
using App.PhoneBook.Business.Concrete;
using App.PhoneBook.DataAccess.Abstract;
using App.PhoneBook.DataAccess.Concrete;
using App.PhoneBook.WebUILayer.IdentityEntities;
using App.PhoneBook.WebUILayer.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.PhoneBook.WebUILayer
{
    public class Startup
    {


        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IEmployeeService,EmployeeService>();
            services.AddScoped<IEmployeeDal, EmployeeDal>();
            services.AddScoped<IDepartmentDal, DepartmentDal>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer(@"Server=HHHH\SQLEXPRESS;Database=PhoneBook;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();

            services.AddMvc();

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();

            app.UseAuthentication();

            app.UseNodeModules(env.ContentRootPath);

            app.UseMvc(ConfigureRoutes);

            SeedIdentity.CreateIdentityUsers(app.ApplicationServices, configuration).Wait();

        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Employee}/{action=Index}");

            routeBuilder.MapRoute("Second", "{controller=Account}/{action=Login}");

            routeBuilder.MapRoute("Third", "{controller=Admin}/{action=Index}");

            routeBuilder.MapRoute("Forth", "{controller=Department}/{action=Index}");
        }
    }
}
// Update Operations