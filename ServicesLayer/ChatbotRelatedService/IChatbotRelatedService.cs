using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ChatbotRelatedService
{
    public interface IChatbotRelatedService
    {
        IEnumerable<ChatbotRelated> GetAllChatbotRelated();
        ChatbotRelated GetChatbotRelated(int id);
        void InSertChatbotRelated(ChatbotRelated chatbotRelated);
        void UpdateChatbotRelated(ChatbotRelated chatbotRelated);
        void DeleteChatbotRelated(int id);
    }
}
