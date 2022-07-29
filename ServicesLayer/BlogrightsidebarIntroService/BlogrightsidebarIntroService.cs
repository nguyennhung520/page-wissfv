using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BlogrightsidebarIntroService
{
    public class BlogrightsidebarIntroService : IBlogrightsidebarIntroService
    {
        private IRepository<BlogrightsidebarIntro> repository;
        public BlogrightsidebarIntroService(IRepository<BlogrightsidebarIntro> repository)
        {
            this.repository = repository;
        }
        public void DeleteBlogrightsidebarIntro(int id)
        {
            BlogrightsidebarIntro blogrightsidebarIntro = GetBlogrightsidebarIntro(id);
            repository.Delete(blogrightsidebarIntro);
            repository.SaveChanges();
        }

        public IEnumerable<BlogrightsidebarIntro> GetAllBlogrightsidebarIntro()
        {
            return repository.GetAll();
        }

        public BlogrightsidebarIntro GetBlogrightsidebarIntro(int id)
        {
            return repository.Get(id);
        }

        public void InSertBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro)
        {
            repository.Insert(blogrightsidebarIntro);
        }

        public void UpdateBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro)
        {
            repository.Update(blogrightsidebarIntro);
        }
    }
}
