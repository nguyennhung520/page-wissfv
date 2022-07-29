using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationDemoService
{
    public class ConversationDemoService : IConversationDemoService
    {
        private IRepository<ConversationDemo> repository;
        public ConversationDemoService(IRepository<ConversationDemo> repository)
        {
            this.repository = repository;
        }
        public void DeleteConversationDemo(int id)
        {
            ConversationDemo conversationDemo = GetConversationDemo(id);
            repository.Delete(conversationDemo);
            repository.SaveChanges();
        }

        public IEnumerable<ConversationDemo> GetAllConversationDemo()
        {
            return repository.GetAll();
        }

        public ConversationDemo GetConversationDemo(int id)
        {
            return repository.Get(id);
        }

        public void InSertConversationDemo(ConversationDemo conversationDemo)
        {
            repository.Insert(conversationDemo);
        }

        public void UpdateConversationDemo(ConversationDemo conversationDemo)
        {
            repository.Update(conversationDemo);
        }
    }
}
