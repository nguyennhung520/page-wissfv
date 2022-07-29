using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.NavdropService
{
    public interface INavdropService
    {
        IEnumerable<Navdrop> GetAllNavdrop();
        Navdrop GetNavdrop(int id); 
        void InsertNavdrop(Navdrop navdrop);
        void UpdateNavdrop(Navdrop navdrop);
        void DeleteNavdrop(int id);
    }
}
