using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationDoiTacService
{
    public class ConversationDoiTacService : IConversationDoiTacService
    {
        private IRepository<ConversationDoiTac> repository;
        public ConversationDoiTacService(IRepository<ConversationDoiTac> repository)
        {
            this.repository = repository;
        }
        public void DeleteConversationDoiTac(int id)
        {
            ConversationDoiTac conversationDoiTac = GetConversationDoiTac(id);
            repository.Delete(conversationDoiTac);
            repository.SaveChanges();
        }

        public IEnumerable<ConversationDoiTac> GetAllConversationDoiTac()
        {
            return repository.GetAll();
        }

        public ConversationDoiTac GetConversationDoiTac(int id)
        {
            return repository.Get(id);
        }

        public void InSertConversationDoiTac(ConversationDoiTac conversationDoiTac)
        {
            repository.Insert(conversationDoiTac);
        }

        public void UpdateConversationDoiTac(ConversationDoiTac conversationDoiTac)
        {
            repository.Update(conversationDoiTac);
        }
    }
}
