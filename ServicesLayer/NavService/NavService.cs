using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.NavService
{
    public class NavService : INavService
    {
        private IRepository<Nav> repo;
        public NavService(IRepository<Nav> repo)
        {
            this.repo = repo;
        }
        public void DeleteNav(int id)
        {
            Nav nav = GetNav(id);
            repo.Delete(nav);
            repo.SaveChanges();
        }

        public IEnumerable<Nav> GetAllNav()
        {
            return repo.GetAll();
        }

        public Nav GetNav(int id)
        {
            return repo.Get(id);
        }

        public void InSertNav(Nav nav)
        {
            repo.Insert(nav);
        }

        public void UpdateNav(Nav nav)
        {
            repo.Update(nav);
        }
    }
}
