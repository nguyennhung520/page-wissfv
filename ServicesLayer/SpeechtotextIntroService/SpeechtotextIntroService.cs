using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextIntroService
{
    public class SpeechtotextIntroService : ISpeechtotextIntroService
    {
        private IRepository<SpeechtotextIntro> repository;
        public SpeechtotextIntroService(IRepository<SpeechtotextIntro> repository)
        {
            this.repository = repository;
        }

        public void DeleteSpeechtotextIntro(int id)
        {
            SpeechtotextIntro speechtotextIntro = GetSpeechtotextIntro(id);
            repository.Remove(speechtotextIntro);
            repository.SaveChanges();
        }

        public IEnumerable<SpeechtotextIntro> GetAllSpeechtotextIntro()
        {
            return repository.GetAll();
        }

        public SpeechtotextIntro GetSpeechtotextIntro(int id)
        {
            return repository.Get(id);
        }

        public void InsertSpeechtotextIntro(SpeechtotextIntro speechtotextIntro)
        {
            repository.Insert(speechtotextIntro);
        }

        public void UpdateSpeechtotextIntro(SpeechtotextIntro speechtotextIntro)
        {
            repository.Update(speechtotextIntro);
        }
    }
}
