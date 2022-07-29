using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachDemoService
{
    public class OurapproachDemoService : IOurapproachDemoService
    {
        private IRepository<OurapproachDemo> repository;
        public OurapproachDemoService(IRepository<OurapproachDemo> repository)
        {
            this.repository = repository;
        }

        public void DeleteOurapproachDemo(int id)
        {
            OurapproachDemo ourapproachDemo = GetOurapproachDemo(id);
            repository.Remove(ourapproachDemo);
            repository.SaveChanges();
        }

        public IEnumerable<OurapproachDemo> GetAllOurapproachDemo()
        {
            return repository.GetAll();
        }

        public OurapproachDemo GetOurapproachDemo(int id)
        {
            return repository.Get(id);
        }

        public void InsertOurapproachDemo(OurapproachDemo ourapproachDemo)
        {
            repository.Insert(ourapproachDemo);
        }

        public void UpdateOurapproachDemo(OurapproachDemo ourapproachDemo)
        {
            repository.Update(ourapproachDemo);
        }
    }
}
