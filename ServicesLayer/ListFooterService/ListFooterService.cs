using DomainLayer.Model;
using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ListFooterService
{
    public class ListFooterService : IListFooterService
    {
        private IRepository<ListFooter> repository;
        public ListFooterService(IRepository<ListFooter> repository)
        {
            this.repository = repository;
        }
        public void DeleteListFooter(int id)
        {
            ListFooter listFooter = GetListFooter(id);
            repository.Delete(listFooter);
            repository.SaveChanges();
        }

        public IEnumerable<ListFooter> GetAllListFooter()
        {
            return repository.GetAll();
        }

        public ListFooter GetListFooter(int id)
        {
            return repository.Get(id);
        }

        public void InSertListFooter(ListFooter listFooter)
        {
            repository.Insert(listFooter);
        }

        public void UpdateListFooter(ListFooter listFooter)
        {
            repository.Update(listFooter);
        }
    }
}
