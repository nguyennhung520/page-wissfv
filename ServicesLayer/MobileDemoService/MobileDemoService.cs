using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileDemoService
{
    public class MobileDemoService : IMobileDemoService
    {
        private IRepository<MobileDemo> repository;
        public MobileDemoService(IRepository<MobileDemo> repository)
        {
            this.repository = repository;
        }
        public void DeleteMobileDemo(int id)
        {
            MobileDemo mobileDemo = GetMobileDemo(id);
            repository.Remove(mobileDemo);
            repository.SaveChanges();
        }

        public IEnumerable<MobileDemo> GetAllMobileDemo()
        {
            return repository.GetAll();
        }

        public MobileDemo GetMobileDemo(int id)
        {
            return repository.Get(id);
        }

        public void InsertMobileDemo(MobileDemo mobileDemo)
        {
            repository.Insert(mobileDemo);
        }

        public void UpdateMobileDemo(MobileDemo mobileDemo)
        {
            repository.Update(mobileDemo);
        }
    }
}
