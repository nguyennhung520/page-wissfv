using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.LoginFormService
{
    public class LoginFormService : ILoginFormService
    {
        private IRepository<LoginForm> repository;
        public LoginFormService(IRepository<LoginForm> repository)
        {
            this.repository = repository;
        }
        public void DeleteLoginForm(int id)
        {
            LoginForm loginForm = GetLoginForm(id);
            repository.Remove(loginForm);
            repository.SaveChanges();
        }

        public IEnumerable<LoginForm> GetAllLoginForm()
        {
            return repository.GetAll();
        }

        public LoginForm GetLoginForm(int id)
        {
            return repository.Get(id);
        }

        public void InsertLoginForm(LoginForm loginForm)
        {
            repository.Insert(loginForm);
        }

        public void UpdateLoginForm(LoginForm loginForm)
        {
            repository.Update(loginForm);
        }
    }
}
