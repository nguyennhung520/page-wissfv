using DomainLayer.Model;
using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.FooterService
{
    public class FooterService : IFooterService
    {
        private IRepository<Footer> repository;
        public FooterService(IRepository<Footer> repository)
        {
            this.repository = repository;
        }

        public void DeleteFooter(int id)
        {
            Footer footer = GetFooter(id);
            repository.Remove(footer);
            repository.SaveChanges();
        }

        public IEnumerable<Footer> GetAllFooter()
        {
            return repository.GetAll();
        }

        public Footer GetFooter(int id)
        {
            return repository.Get(id);
        }

        public void InSertFooter(Footer footer)
        {
            repository.Insert(footer);
        }

        public void UpdateFooter(Footer footer)
        {
            repository.Update(footer);
        }
    }
}
