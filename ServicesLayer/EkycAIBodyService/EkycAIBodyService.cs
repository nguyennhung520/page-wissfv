using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.EkycAIBodyService
{
    public class EkycAIBodyService : IEkycAIBodyService
    {
        private IRepository<EkycAIBody> repository;
        public EkycAIBodyService(IRepository<EkycAIBody> repository)
        {
            this.repository = repository;
        }
        public void DeleteEkycAIBody(int id)
        {
            EkycAIBody ekycAIBody = GetEkycAIBody(id);
            repository.Delete(ekycAIBody);
            repository.SaveChanges();
        }

        public IEnumerable<EkycAIBody> GetAllEkycAIBody()
        {
            return repository.GetAll();
        }

        public EkycAIBody GetEkycAIBody(int id)
        {
            return repository.Get(id);
        }

        public void InSertEkycAIBody(EkycAIBody ekycAIBody)
        {
            repository.Insert(ekycAIBody);
        }

        public void UpdateEkycAIBody(EkycAIBody ekycAIBody)
        {
            repository.Update(ekycAIBody);
        }
    }
}
