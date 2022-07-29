using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationDoiTacService
{
    public interface IConversationDoiTacService
    {
        IEnumerable<ConversationDoiTac> GetAllConversationDoiTac();
        ConversationDoiTac GetConversationDoiTac(int id);
        void InSertConversationDoiTac(ConversationDoiTac conversationDoiTac);
        void UpdateConversationDoiTac(ConversationDoiTac conversationDoiTac);
        void DeleteConversationDoiTac(int id);
    }
}
