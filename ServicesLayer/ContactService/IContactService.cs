using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ContactService
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAllContact();
        Contact GetContact(int id);
        void InsertContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
    }
}
