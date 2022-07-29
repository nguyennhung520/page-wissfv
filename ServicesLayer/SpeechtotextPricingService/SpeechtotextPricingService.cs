using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextPricingService
{
    public class SpeechtotextPricingService : ISpeechtotextPricingService
    {
        private IRepository<SpeechtotextPricing> repository;
        public SpeechtotextPricingService(IRepository<SpeechtotextPricing> repository)
        {
            this.repository = repository;
        }

        public void DeleteSpeechtotextPricing(int id)
        {
            SpeechtotextPricing speechtotextPricing = GetSpeechtotextPricing(id);
            repository.Remove(speechtotextPricing);
            repository.SaveChanges();
        }

        public IEnumerable<SpeechtotextPricing> GetAllSpeechtotextPricing()
        {
            return repository.GetAll();
        }

        public SpeechtotextPricing GetSpeechtotextPricing(int id)
        {
            return repository.Get(id);
        }

        public void InsertSpeechtotextPricing(SpeechtotextPricing speechtotextPricing)
        {
            repository.Insert(speechtotextPricing);
        }

        public void UpdateSpeechtotextPricing(SpeechtotextPricing speechtotextPricing)
        {
            repository.Update(speechtotextPricing);
        }
    }
}
