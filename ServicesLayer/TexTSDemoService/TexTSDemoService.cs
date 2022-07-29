
using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSDemoService
{
    public class TexTSDemoService : ITexTSDemoService
    {
        private IRepository<TexTSDemo> repository;
        public TexTSDemoService(IRepository<TexTSDemo> repository)
        {
            this.repository = repository;
        }

        public void DeleteTexTSDemo(int id)
        {
            TexTSDemo texTSDemo = GetTexTSDemo(id);
            repository.Remove(texTSDemo);
            repository.SaveChanges();
        }

        public IEnumerable<TexTSDemo> GetAllTexTSDemo()
        {
            return repository.GetAll();
        }

        public TexTSDemo GetTexTSDemo(int id)
        {
            return repository.Get(id);
        }

        public void InsertTexTSDemo(TexTSDemo texTSDemo)
        {
            repository.Insert(texTSDemo);
        }

        public void UpdateTexTSDemo(TexTSDemo texTSDemo)
        {
            repository.Update(texTSDemo);
        }
    }
}
