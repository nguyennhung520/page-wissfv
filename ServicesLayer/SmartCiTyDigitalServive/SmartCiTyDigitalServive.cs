using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTyDigitalServive
{
    public class SmartCiTyDigitalServive : ISmartCiTyDigitalServive
    {
        private IRepository<SmartCiTyDigital> repository;
        public SmartCiTyDigitalServive(IRepository<SmartCiTyDigital> repository)
        {
            this.repository = repository;
        }

        public void DeleteSmartCiTyDigital(int id)
        {
            SmartCiTyDigital smartCiTyDigital = GetSmartCiTyDigital(id);
            repository.Remove(smartCiTyDigital);
            repository.SaveChanges();
        }

        public IEnumerable<SmartCiTyDigital> GetAllSmartCiTyDigital()
        {
            return repository.GetAll();
        }

        public SmartCiTyDigital GetSmartCiTyDigital(int id)
        {
            return repository.Get(id);
        }

        public void InsertSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital)
        {
            repository.Insert(smartCiTyDigital);
        }

        public void UpdateSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital)
        {
            repository.Update(smartCiTyDigital);
        }
    }
}
