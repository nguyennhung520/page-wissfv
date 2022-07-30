using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ChatbotRelatedService
{
    public class ChatbotRelatedService : IChatbotRelatedService
    {
        private IRepository<ChatbotRelated> repository;
        public ChatbotRelatedService(IRepository<ChatbotRelated> repository)
        {
            this.repository = repository;
        }
        public void DeleteChatbotRelated(int id)
        {
            ChatbotRelated chatbotRelated = GetChatbotRelated(id);
            repository.Delete(chatbotRelated);
            repository.SaveChanges();
        }

        public IEnumerable<ChatbotRelated> GetAllChatbotRelated()
        {
            return repository.GetAll();
        }

        public ChatbotRelated GetChatbotRelated(int id)
        {
            return repository.Get(id);
        }

        public void InSertChatbotRelated(ChatbotRelated chatbotRelated)
        {
            repository.Insert(chatbotRelated);
        }

        public void UpdateChatbotRelated(ChatbotRelated chatbotRelated)
        {
            repository.Update(chatbotRelated);
        }
    }
}
