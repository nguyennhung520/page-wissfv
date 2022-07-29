using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MenuGroupService
{
    public interface IMenuGroupService
    {
        IEnumerable<MenuGroup> GetAllMenuGroup();
        MenuGroup GetMenuGroup(int id);
        void InSertMenuGroup(MenuGroup menuGroup);
        void UpdateMenuGroup(MenuGroup menuGroup);
        void DeleteMenuGroup(int id);
    }
}
