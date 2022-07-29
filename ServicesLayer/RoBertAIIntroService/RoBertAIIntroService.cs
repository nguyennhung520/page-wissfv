using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIIntroService
{
    public class RoBertAIIntroService : IRoBertAIIntroService
    {
        private IRepository<RoBertAIIntro> repository;
        public RoBertAIIntroService(IRepository<RoBertAIIntro> repository)
        {
            this.repository = repository;
        }
        public void DeleteRoBertAIIntro(int id)
        {
            RoBertAIIntro roBertAIIntro = GetRoBertAIIntro(id);
            repository.Remove(roBertAIIntro);
            repository.SaveChanges();
        }

        public IEnumerable<RoBertAIIntro> GetAllRoBertAIIntro()
        {
            return repository.GetAll();
        }

        public RoBertAIIntro GetRoBertAIIntro(int id)
        {
            return repository.Get(id);
        }

        public void InsertRoBertAIIntro(RoBertAIIntro roBertAIIntro)
        {
            repository.Insert(roBertAIIntro);
        }

        public void UpdateRoBertAIIntro(RoBertAIIntro roBertAIIntro)
        {
            repository.Update(roBertAIIntro);
        }
    }
}
