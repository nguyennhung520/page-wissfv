using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextDemoService
{
    public class SpeechtotextDemoService : ISpeechtotextDemoService
    {
        private IRepository<SpeechtotextDemo> repository;
        public SpeechtotextDemoService(IRepository<SpeechtotextDemo> repository)
        {
            this.repository = repository;
        }

        public void DeleteSpeechtotextDemo(int id)
        {
            SpeechtotextDemo speechtotextDemo = GetSpeechtotextDemo(id);
            repository.Remove(speechtotextDemo);
            repository.SaveChanges();
        }

        public IEnumerable<SpeechtotextDemo> GetAllSpeechtotextDemo()
        {
            return repository.GetAll();
        }

        public SpeechtotextDemo GetSpeechtotextDemo(int id)
        {
            return repository.Get(id);
        }

        public void InsertSpeechtotextDemo(SpeechtotextDemo speechtotextDemo)
        {
            repository.Insert(speechtotextDemo);
        }

        public void UpdateSpeechtotextDemo(SpeechtotextDemo speechtotextDemo)
        {
            repository.Update(speechtotextDemo);
        }
    }
}
