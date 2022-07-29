using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;
using RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository;
using ServicesLayer.ContactService;
using ServicesLayer.NavService;
using ServicesLayer.NavdropService;
using ServicesLayer.MenuGroupService;
using ServicesLayer.listMenuService;
using ServicesLayer.FooterService;
using ServicesLayer.ListFooterService;
using ServicesLayer.BeehiveDemosService;
using ServicesLayer.BeehiveFeaturesService;
using ServicesLayer.TexTSDemoService;
using ServicesLayer.TexTSIntroService;
using ServicesLayer.TexTSPricingService;
using ServicesLayer.SpeechtotextDemoService;
using ServicesLayer.SpeechtotextIntroService;
using ServicesLayer.SpeechtotextPricingService;
using ServicesLayer.OurapproachDemoService;
using ServicesLayer.OurapproachIntroService;
using ServicesLayer.OurapproachSolutionService;
using ServicesLayer.RoBertAIBodyService;
using ServicesLayer.RoBertAIIntroService;
using ServicesLayer.RoBertAIPricingService;
using ServicesLayer.RoBertAIReviewsService;
using ServicesLayer.LoginFormService;
using ServicesLayer.MobileBackedService;
using ServicesLayer.MobileDemoService;
using ServicesLayer.MobileSubscribeService;
using ServicesLayer.SmartCiTyDigitalServive;
using ServicesLayer.SmartCiTyEmpowerService;
using ServicesLayer.SmartCiTySolutionService;
using ServicesLayer.BlogrightsidebarCategoriesService;
using ServicesLayer.BlogrightsidebarIntroService;
using ServicesLayer.ChatbotBlogService;
using ServicesLayer.ChatbotRelatedService;
using ServicesLayer.ComputervisonFormcontactService;
using ServicesLayer.ConversationDemoService;
using ServicesLayer.ConversationDoiTacService;
using ServicesLayer.ConversationIntroService;
using ServicesLayer.ConversationPricingService;
using ServicesLayer.DatasciencesDemoService;
using ServicesLayer.DatasciencesExpertiseService;
using ServicesLayer.EkycAIBodyService;

namespace pagewis
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "pagewis", Version = "v1" });
            });
            services.AddDbContext<WisDBContact>(item => item.UseSqlServer(Configuration.GetConnectionString("conn")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<INavService, NavService>();
            services.AddTransient<INavdropService, NavdropService>();
            services.AddTransient<IMenuGroupService, MenuGroupService>();
            services.AddTransient<IlistMenuService, listMenuService>();
            services.AddTransient<IFooterService, FooterService>();
            services.AddTransient<IListFooterService, ListFooterService>();
            services.AddTransient<IBeehiveDemosService, BeehiveDemosService>();
            services.AddTransient<IBeehiveFeaturesService, BeehiveFeaturesService>();
            services.AddTransient<ITexTSDemoService, TexTSDemoService>();
            services.AddTransient<ITexTSIntroService, TexTSIntroService>();
            services.AddTransient<ITexTSPricingService, TexTSPricingService>();
            services.AddTransient<ISpeechtotextDemoService, SpeechtotextDemoService>();
            services.AddTransient<ISpeechtotextIntroService, SpeechtotextIntroService>();
            services.AddTransient<ISpeechtotextPricingService, SpeechtotextPricingService>();
            services.AddTransient<IOurapproachDemoService, OurapproachDemoService>();
            services.AddTransient<IOurapproachIntroService, OurapproachIntroService>();
            services.AddTransient<IOurapproachSolutionService, OurapproachSolutionService>();
            services.AddTransient<IRoBertAIBodyService, RoBertAIBodyService>();
            services.AddTransient<IRoBertAIIntroService, RoBertAIIntroService>();
            services.AddTransient<IRoBertAIPricingService, RoBertAIPricingService>();
            services.AddTransient<IRoBertAIReviewsService, RoBertAIReviewsService>();

            services.AddTransient<ILoginFormService, LoginFormService>();
            services.AddTransient<IMobileBackedService, MobileBackedService>();
            services.AddTransient<IMobileDemoService, MobileDemoService>();
            services.AddTransient<ISmartCiTyDigitalServive, SmartCiTyDigitalServive>();
            services.AddTransient<ISmartCiTyEmpowerService, SmartCiTyEmpowerService>();
            services.AddTransient<ISmartCiTySolutionService, SmartCiTySolutionService>();
            services.AddTransient<IMobileSubscribeService, MobileSubscribeService>();

            services.AddTransient<IBlogrightsidebarCategoriesService, BlogrightsidebarCategoriesService>();
            services.AddTransient<IBlogrightsidebarIntroService, BlogrightsidebarIntroService>();
            services.AddTransient<IChatbotBlogService, ChatbotBlogService>();
            services.AddTransient<IChatbotRelatedService, ChatbotRelatedService>();
            services.AddTransient<IComputervisonFormcontactService, ComputervisonFormcontactService>();
            services.AddTransient<IConversationDemoService, ConversationDemoService>();
            services.AddTransient<IConversationDoiTacService, ConversationDoiTacService>();
            services.AddTransient<IConversationIntroService, ConversationIntroService>();
            services.AddTransient<IConversationPricingService, ConversationPricingService>();
            services.AddTransient<IDatasciencesDemoService, DatasciencesDemoService>();
            services.AddTransient<IDatasciencesExpertiseService, DatasciencesExpertiseService>();
            services.AddTransient<IEkycAIBodyService, EkycAIBodyService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "pagewis v1"));

            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
