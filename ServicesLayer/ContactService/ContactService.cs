using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ContactService
{
    public class ContactService : IContactService
    {
        private IRepository<Contact> repository;
        public ContactService(IRepository<Contact> repository)
        {
            this.repository = repository;
        }
        public void DeleteContact(int id)
        {
            Contact contact = GetContact(id);
            repository.Remove(contact);
            repository.SaveChanges();
        }

        public IEnumerable<Contact> GetAllContact()
        {
            return repository.GetAll();
        }

        public Contact GetContact(int id)
        {
            return repository.Get(id);
        }

        public void InsertContact(Contact contact)
        {
            repository.Insert(contact);
        }

        public void UpdateContact(Contact contact)
        {
            repository.Update(contact);
        }

    }
}
