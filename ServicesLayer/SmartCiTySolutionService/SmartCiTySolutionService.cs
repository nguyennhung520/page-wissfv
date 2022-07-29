using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTySolutionService
{
    public class SmartCiTySolutionService : ISmartCiTySolutionService
    {
        private IRepository<SmartCiTySolution> repository;
        public SmartCiTySolutionService(IRepository<SmartCiTySolution> repository)
        {
            this.repository = repository;
        }

        public void DeleteSmartCiTySolution(int id)
        {
            SmartCiTySolution smartCiTySolution = GetSmartCiTySolution(id);
            repository.Remove(smartCiTySolution);
            repository.SaveChanges();
        }

        public IEnumerable<SmartCiTySolution> GetAllSmartCiTySolution()
        {
            return repository.GetAll();
        }

        public SmartCiTySolution GetSmartCiTySolution(int id)
        {
            return repository.Get(id);
        }

        public void InsertSmartCiTySolution(SmartCiTySolution smartCiTySolution)
        {
            repository.Insert(smartCiTySolution);
        }

        public void UpdateSmartCiTySolution(SmartCiTySolution smartCiTySolution)
        {
            repository.Update(smartCiTySolution);
        }
    }
}
