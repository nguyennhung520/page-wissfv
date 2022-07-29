using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BlogrightsidebarCategoriesService
{
    public class BlogrightsidebarCategoriesService : IBlogrightsidebarCategoriesService
    {
        private IRepository<BlogrightsidebarCategories> repository;
        public BlogrightsidebarCategoriesService(IRepository<BlogrightsidebarCategories> repository)
        {
            this.repository = repository;
        }

        public void DeleteBlogrightsidebarCategories(int id)
        {
            BlogrightsidebarCategories blogrightsidebarCategories = GetBlogrightsidebarCategories(id);
            repository.Delete(blogrightsidebarCategories);
            repository.SaveChanges();
        }

        public IEnumerable<BlogrightsidebarCategories> GetAllBlogrightsidebarCategories()
        {
            return repository.GetAll();
        }

        public BlogrightsidebarCategories GetBlogrightsidebarCategories(int id)
        {
            return repository.Get(id);
        }

        public void InSertBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories)
        {
            repository.Insert(blogrightsidebarCategories);
        }

        public void UpdateBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories)
        {
            repository.Update(blogrightsidebarCategories);
        }
    }
}
