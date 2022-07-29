using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationIntroService
{
    public class ConversationIntroService : IConversationIntroService
    {
        private IRepository<ConversationIntro> repository;
        public ConversationIntroService(IRepository<ConversationIntro> repository)
        {
            this.repository = repository;
        }

        public void DeleteConversationIntro(int id)
        {
            ConversationIntro conversationIntro = GetConversationIntro(id);
            repository.Delete(conversationIntro);
            repository.SaveChanges();
        }

        public IEnumerable<ConversationIntro> GetAllConversationIntro()
        {
            return repository.GetAll();
        }

        public ConversationIntro GetConversationIntro(int id)
        {
            return repository.Get(id);
        }

        public void InSertConversationIntro(ConversationIntro conversationIntro)
        {
            repository.Insert(conversationIntro);
        }

        public void UpdateConversationIntro(ConversationIntro conversationIntro)
        {
            repository.Update(conversationIntro);
        }
    }
}
