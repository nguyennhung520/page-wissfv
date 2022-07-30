using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ConversationDemoService
{
    public interface IConversationDemoService
    {
        IEnumerable<ConversationDemo> GetAllConversationDemo();
        ConversationDemo GetConversationDemo(int id);
        void InSertConversationDemo(ConversationDemo conversationDemo);
        void UpdateConversationDemo(ConversationDemo conversationDemo);
        void DeleteConversationDemo(int id);
    }
}
