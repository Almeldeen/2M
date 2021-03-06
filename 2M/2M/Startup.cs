
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DAL.Contanier;
using DAL.Reposatiories.JopRepo;
using BLL.Services.JopService;
using BLL.Mapper;
using DAL.Reposatiories.EmpRepo;
using BLL.Services.EmpServies;
using DAL.Reposatiories.AccRepo;
using BLL.Services.AccServies;
using BLL.Services.SupplierServies;
using DAL.Reposatiories.SupplierRepo;
using DAL.Reposatiories.AttendRepo;
using BLL.Services.AttendServies;
using DAL.Reposatiories.EmpExpensesRepo;
using BLL.Services.EmpExpensesService;
using BLL.Services.EmpExpensesServices;

namespace _2M
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
            services.AddScoped<IJopService, JopService>();
            services.AddScoped<IEmpServies, EmpServies>();
            services.AddScoped<IAccServies, AccServies>();
            services.AddScoped<IAttendServies, AttendServies>();
            services.AddScoped<ISupplierServies, SupplierServies>();
            services.AddScoped<IEmpExpensesServies, EmpExpensesServices>();
            services.AddScoped<IJopRepo, JopRepo>();
            services.AddScoped<IAccRepo, AccRepo>();
            services.AddScoped<IEmpRepo, EmpRepo>();
            services.AddScoped<IAttendRepo, AttendRepo>();
            services.AddScoped<ISupplierRepo, SupplierRepo>();
            services.AddScoped<IEmpExpensesRepo, EmpExpensesRepo>();
           
            services.AddAutoMapper(x => x.AddProfile(new DominProfile()));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplacationDbContext>();
            services.AddDbContext<ApplacationDbContext>(option =>
            option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
