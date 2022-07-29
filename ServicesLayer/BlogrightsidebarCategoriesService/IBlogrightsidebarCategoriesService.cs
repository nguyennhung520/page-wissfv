using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BlogrightsidebarCategoriesService
{
    public interface IBlogrightsidebarCategoriesService
    {
        IEnumerable<BlogrightsidebarCategories> GetAllBlogrightsidebarCategories();
        BlogrightsidebarCategories GetBlogrightsidebarCategories(int id);
        void InSertBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories);
        void UpdateBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories);
        void DeleteBlogrightsidebarCategories(int id);
    }
}
