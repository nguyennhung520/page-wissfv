using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSIntroService
{
    public class TexTSIntroService : ITexTSIntroService
    {
        private IRepository<TexTSIntro> repository;
        public TexTSIntroService(IRepository<TexTSIntro> repository)
        {
            this.repository = repository;
        }

        public void DeleteTexTSIntro(int id)
        {
            TexTSIntro texTSIntro = GetTexTSIntro(id);
            repository.Remove(texTSIntro);
            repository.SaveChanges();
        }

        public IEnumerable<TexTSIntro> GetAllTexTSIntro()
        {
            return repository.GetAll();
        }

        public TexTSIntro GetTexTSIntro(int id)
        {
            return repository.Get(id);
        }

        public void InsertTexTSIntro(TexTSIntro texTSIntro)
        {
            repository.Insert(texTSIntro);
        }

        public void UpdateTexTSIntro(TexTSIntro texTSIntro)
        {
            repository.Update(texTSIntro);
        }
    }
}
