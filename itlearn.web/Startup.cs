using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itlearn.bll.Interfaces;
using itlearn.bll.Services;
using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.dal.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace itlearn.web
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
            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("itlearn")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IChapterService, ChapterService>();
            services.AddTransient<IThemeService, ThemeService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IAnswerService, AnswerService>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IAchievementService, AchievementService>();
            services.AddTransient<IAdviceService, AdviceService>();
            services.AddTransient<IStoryServices, StoryService>();

            services.AddMvc();
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
            }

            app.UseStatusCodePagesWithReExecute("/StatusCode/{0}");
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
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
