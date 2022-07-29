using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIBodyService
{
    public class RoBertAIBodyService : IRoBertAIBodyService
    {
        private IRepository<RoBertAIBody> repository;
        public RoBertAIBodyService(IRepository<RoBertAIBody> repository)
        {
            this.repository = repository;
        }
        public void DeleteRoBertAIBody(int id)
        {
            RoBertAIBody roBertAIBody = GetRoBertAIBody(id);
            repository.Remove(roBertAIBody);
            repository.SaveChanges();
        }

        public IEnumerable<RoBertAIBody> GetAllRoBertAIBody()
        {
            return repository.GetAll();
        }

        public RoBertAIBody GetRoBertAIBody(int id)
        {
            return repository.Get(id);
        }

        public void InsertRoBertAIBody(RoBertAIBody roBertAIBody)
        {
            repository.Insert(roBertAIBody);
        }

        public void UpdateRoBertAIBody(RoBertAIBody roBertAIBody)
        {
            repository.Update(roBertAIBody);
        }
    }
}
