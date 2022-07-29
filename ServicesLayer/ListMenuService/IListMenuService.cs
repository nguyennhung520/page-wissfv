using DomainLayer.Model;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.listMenuService
{
    public interface IlistMenuService
    {
        IEnumerable<ListMenu> GetAllListMenu();
        ListMenu GetListMenu(int id);
        void InSertListMenu(ListMenu listMenu);
        void UpdateListMenu(ListMenu listMenu);
        void DeleteListMenu(int id);
    }
}
