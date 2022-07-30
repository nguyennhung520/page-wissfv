using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTyEmpowerService
{
    public class SmartCiTyEmpowerService : ISmartCiTyEmpowerService
    {
        private IRepository<SmartCiTyEmpower> repository;
        public SmartCiTyEmpowerService(IRepository<SmartCiTyEmpower> repository)
        {
            this.repository = repository;
        }

        public void DeleteSmartCiTyEmpower(int id)
        {
            SmartCiTyEmpower smartCiTyEmpower = GetSmartCiTyEmpower(id);
            repository.Remove(smartCiTyEmpower);
            repository.SaveChanges();
        }

        public IEnumerable<SmartCiTyEmpower> GetAllSmartCiTyEmpower()
        {
            return repository.GetAll();
        }

        public SmartCiTyEmpower GetSmartCiTyEmpower(int id)
        {
            return repository.Get(id);
        }

        public void InsertSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower)
        {
            repository.Insert(smartCiTyEmpower);
        }

        public void UpdateSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower)
        {
            repository.Update(smartCiTyEmpower);
        }
    }
}
