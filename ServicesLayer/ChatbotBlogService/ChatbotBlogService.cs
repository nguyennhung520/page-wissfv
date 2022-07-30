using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ChatbotBlogService
{
    public class ChatbotBlogService : IChatbotBlogService
    {
        private IRepository<ChatbotBlog> repository;
        public ChatbotBlogService(IRepository<ChatbotBlog> repository)
        {
            this.repository = repository;
        }
        public void DeleteChatbotBlog(int id)
        {
            ChatbotBlog chatbotBlog = GetChatbotBlog(id);
            repository.Delete(chatbotBlog);
            repository.SaveChanges();
        }

        public IEnumerable<ChatbotBlog> GetAllChatbotBlog()
        {
            return repository.GetAll();
        }

        public ChatbotBlog GetChatbotBlog(int id)
        {
            return repository.Get(id);
        }

        public void InsertChatbotBlog(ChatbotBlog chatbotBlog)
        {
            repository.Insert(chatbotBlog);
        }

        public void UpdateChatbotBlog(ChatbotBlog chatbotBlog)
        {
            repository.Update(chatbotBlog);
        }
    }
}
