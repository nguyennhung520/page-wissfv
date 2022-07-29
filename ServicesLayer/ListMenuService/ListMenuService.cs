using DomainLayer.Model;
using DomainLayer.Models;
using RepositoryLayer.Repository;
using ServicesLayer.listMenuService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.listMenuService
{
    public class listMenuService : IlistMenuService
    {
        private IRepository<ListMenu> repository;
        public listMenuService(IRepository<ListMenu> repository)
        {
            this.repository = repository;
        }

        public void DeleteListMenu(int id)
        {
            ListMenu listMenu = GetListMenu(id);
            repository.Remove(listMenu);
            repository.SaveChanges();
        }

        public IEnumerable<ListMenu> GetAllListMenu()
        {
            return repository.GetAll();
        }

        public ListMenu GetListMenu(int id)
        {
            return repository.Get(id);
        }

        public void InSertListMenu(ListMenu listMenu)
        {
            repository.Insert(listMenu);
        }

        public void UpdateListMenu(ListMenu listMenu)
        {
            repository.Update(listMenu);
        }
    }
}
