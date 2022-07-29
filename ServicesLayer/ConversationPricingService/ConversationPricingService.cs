using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationPricingService
{
    public class ConversationPricingService : IConversationPricingService
    {
        private IRepository<ConversationPricing> repository;
        public ConversationPricingService(IRepository<ConversationPricing> repository)
        {
            this.repository = repository;
        }
        public void DeleteConversationPricing(int id)
        {
            ConversationPricing conversationPricing = GetConversationPricing(id);
            repository.Delete(conversationPricing);
            repository.SaveChanges();
        }

        public IEnumerable<ConversationPricing> GetAllConversationPricing()
        {
            return repository.GetAll();
        }

        public ConversationPricing GetConversationPricing(int id)
        {
            return repository.Get(id);
        }

        public void InSertConversationPricing(ConversationPricing conversationPricing)
        {
            repository.Insert(conversationPricing);
        }

        public void UpdateConversationPricing(ConversationPricing conversationPricing)
        {
            repository.Update(conversationPricing);
        }
    }
}
