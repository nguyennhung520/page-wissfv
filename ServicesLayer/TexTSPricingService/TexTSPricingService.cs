using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSPricingService
{
    public class TexTSPricingService : ITexTSPricingService
    {
        private IRepository<TexTSPricing> repository;
        public TexTSPricingService(IRepository<TexTSPricing> repository)
        {
            this.repository = repository;
        }

        public void DeleteTexTSPricing(int id)
        {
            TexTSPricing texTSPricing = GetTexTSPricing(id);
            repository.Remove(texTSPricing);
            repository.SaveChanges();
        }

        public IEnumerable<TexTSPricing> GetAllTexTSPricing()
        {
            return repository.GetAll();
        }

        public TexTSPricing GetTexTSPricing(int id)
        {
            return repository.Get(id);
        }

        public void InsertTexTSPricing(TexTSPricing texTSPricing)
        {
            repository.Insert(texTSPricing);
        }

        public void UpdateTexTSPricing(TexTSPricing texTSPricing)
        {
            repository.Update(texTSPricing);
        }
    }
}
