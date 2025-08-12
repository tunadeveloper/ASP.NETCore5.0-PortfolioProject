using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.DataAccessLayer.EntityFramework;
using PortfolioProject.EntityLayer.Concrete;
using PortfolioProject.PresentationLayer.Areas.Writer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.PresentationLayer
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

            services.AddDbContext<Context>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDAL, EfFeatureDAL>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDAL, EfAboutDAL>();

            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISkillDAL, EfSkillDAL>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDAL, EfTestimonialDAL>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDAL, EfContactDAL>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDAL, EfSocialMediaDAL>();

            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceDAL, EfExperienceDAL>();

            services.AddScoped<IPortfolioService, PortfolioManager>();
            services.AddScoped<IPortfolioDAL, EfPortfolioDAL>();

            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceDAL, EfExperienceDAL>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDAL, EfServiceDAL>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDAL, EfMessageDAL>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IWriterMessageService, WriterMessageManager>();
            services.AddScoped<IWriterMessageDal, EfWriterMessageDal>();

            services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.AccessDeniedPath= "/ErrorPage/Error401";
                options.LoginPath = "/Writer/Login/Index";
            });
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

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
