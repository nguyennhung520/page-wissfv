using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MenuGroupService
{
    public class MenuGroupService : IMenuGroupService
    {
        private IRepository<MenuGroup> repository;
        public MenuGroupService(IRepository<MenuGroup> repository)
        {
            this.repository = repository;
        }

        public void DeleteMenuGroup(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MenuGroup> GetAllMenuGroup()
        {
            throw new NotImplementedException();
        }

        public MenuGroup GetMenuGroup(int id)
        {
            throw new NotImplementedException();
        }

        public void InSertMenuGroup(MenuGroup menuGroup)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenuGroup(MenuGroup menuGroup)
        {
            throw new NotImplementedException();
        }
    }
}
