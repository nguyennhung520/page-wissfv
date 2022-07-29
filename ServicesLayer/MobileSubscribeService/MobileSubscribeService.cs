using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileSubscribeService
{
    public class MobileSubscribeService : IMobileSubscribeService
    {
        private IRepository<MobileSubscribe> repository;
        public MobileSubscribeService(IRepository<MobileSubscribe> repository)
        {
            this.repository = repository;
        }
        public void DeleteMobileSubscribe(int id)
        {
            MobileSubscribe mobileSubscribe = GetMobileSubscribe(id);
            repository.Remove(mobileSubscribe);
            repository.SaveChanges();
        }

        public IEnumerable<MobileSubscribe> GetAllMobileSubscribe()
        {
            return repository.GetAll();
        }

        public MobileSubscribe GetMobileSubscribe(int id)
        {
            return repository.Get(id);
        }

        public void InsertMobileSubscribe(MobileSubscribe mobileSubscribe)
        {
            repository.Insert(mobileSubscribe);
        }

        public void UpdateMobileSubscribe(MobileSubscribe mobileSubscribe)
        {
            repository.Update(mobileSubscribe);
        }
    }
}
