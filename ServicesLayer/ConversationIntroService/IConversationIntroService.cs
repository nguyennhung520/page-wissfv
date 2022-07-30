using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationIntroService
{
    public interface IConversationIntroService
    {
        IEnumerable<ConversationIntro> GetAllConversationIntro();
        ConversationIntro GetConversationIntro(int id);
        void InSertConversationIntro(ConversationIntro conversationIntro);
        void UpdateConversationIntro(ConversationIntro conversationIntro);
        void DeleteConversationIntro(int id);
    }
}
