using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.NavdropService
{
    public class NavdropService : INavdropService
    {
        private IRepository<Navdrop> repository; 
        public NavdropService(IRepository<Navdrop> repository)
        {
            this.repository = repository;
        }
        public void DeleteNavdrop(int id)
        {
            Navdrop navdrop = GetNavdrop(id);
            repository.Remove(navdrop);
            repository.SaveChanges();
        }

        public IEnumerable<Navdrop> GetAllNavdrop()
        {
            return repository.GetAll();
        }

        public Navdrop GetNavdrop(int id)
        {
            return repository.Get(id);
        }

        public void InsertNavdrop(Navdrop navdrop)
        {
            repository.Insert(navdrop);
        }

        public void UpdateNavdrop(Navdrop navdrop)
        {
            repository.Update(navdrop);
        }
    }
}
