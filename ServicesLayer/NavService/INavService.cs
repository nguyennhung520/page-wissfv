using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.NavService
{
    public interface INavService
    {
        IEnumerable<Nav> GetAllNav();
        Nav GetNav(int id);
        void InSertNav(Nav nav);
        void UpdateNav(Nav nav);
        void DeleteNav(int id);
    }
}
