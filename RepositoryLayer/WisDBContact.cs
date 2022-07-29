using DomainLayer.EntityMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class WisDBContact: DbContext
    {
        public WisDBContact(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NavMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NavdropMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FooterMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ListFooterMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MenuGroupMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ListMenuMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BeehiveDemosMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BeehiveFeaturesMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TexTSDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TexTSIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TexTSPricingMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SpeechtotextDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SpeechtotextIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SpeechtotextPricingMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OurapproachDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OurapproachIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OurapproachSolutionMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoBertAIBodyMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoBertAIIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoBertAIPricingMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoBertAIIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoBertAIReviewsMap());
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LoginFormMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SmartCiTyDigitalMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SmartCiTyEmpowerMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SmartCiTySolutionMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MobileBackedMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MobileDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MobileSubscribeMap());
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BlogrightsidebarCategoriesMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BlogrightsidebarIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChatbotBlogMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChatbotRelatedMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ComputervisonFormcontactMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConversationDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConversationDoiTacMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConversationIntroMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConversationPricingMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DatasciencesDemoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DatasciencesExpertiseMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EkycAIBodyMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
