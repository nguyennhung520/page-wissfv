using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationPricingService
{
    public interface IConversationPricingService
    {
        IEnumerable<ConversationPricing> GetAllConversationPricing();
        ConversationPricing GetConversationPricing(int id);
        void InSertConversationPricing(ConversationPricing conversationPricing);
        void UpdateConversationPricing(ConversationPricing conversationPricing);
        void DeleteConversationPricing(int id);
    }
}
