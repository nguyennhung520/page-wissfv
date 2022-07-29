using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ChatbotBlogService
{
    public interface IChatbotBlogService
    {
        IEnumerable<ChatbotBlog> GetAllChatbotBlog();
        ChatbotBlog GetChatbotBlog(int id);
        void InsertChatbotBlog(ChatbotBlog chatbotBlog);
        void UpdateChatbotBlog(ChatbotBlog chatbotBlog);
        void DeleteChatbotBlog(int id);
    }
}
