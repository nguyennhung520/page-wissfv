using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BlogrightsidebarIntroService
{
    public interface IBlogrightsidebarIntroService
    {
        IEnumerable<BlogrightsidebarIntro> GetAllBlogrightsidebarIntro();
        BlogrightsidebarIntro GetBlogrightsidebarIntro(int id);
        void InSertBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro);
        void UpdateBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro);
        void DeleteBlogrightsidebarIntro(int id);
    }
}
