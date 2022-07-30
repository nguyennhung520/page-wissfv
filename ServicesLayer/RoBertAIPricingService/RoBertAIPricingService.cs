using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIPricingService
{
    public class RoBertAIPricingService : IRoBertAIPricingService
    {
        private IRepository<RoBertAIPricing> repository;
        public RoBertAIPricingService(IRepository<RoBertAIPricing> repository)
        {
            this.repository = repository;
        }
        public void DeleteRoBertAIPricing(int id)
        {
            RoBertAIPricing roBertAIPricing = GetRoBertAIPricing(id);
            repository.Remove(roBertAIPricing);
            repository.SaveChanges();
        }

        public IEnumerable<RoBertAIPricing> GetAllRoBertAIPricing()
        {
            return repository.GetAll();
        }

        public RoBertAIPricing GetRoBertAIPricing(int id)
        {
            return repository.Get(id);
        }

        public void InsertRoBertAIPricing(RoBertAIPricing roBertAIPricing)
        {
            repository.Insert(roBertAIPricing);
        }

        public void UpdateRoBertAIPricing(RoBertAIPricing roBertAIPricing)
        {
            repository.Update(roBertAIPricing);
        }
    }
}
