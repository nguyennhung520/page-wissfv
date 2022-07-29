using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.LoginFormService
{
    public interface ILoginFormService
    {
        IEnumerable<LoginForm> GetAllLoginForm();
        LoginForm GetLoginForm(int id);
        void InsertLoginForm(LoginForm loginForm);
        void UpdateLoginForm(LoginForm loginForm);
        void DeleteLoginForm(int id);
    }
}
