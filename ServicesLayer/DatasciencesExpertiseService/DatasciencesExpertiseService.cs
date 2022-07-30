using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.DatasciencesExpertiseService
{
    public class DatasciencesExpertiseService : IDatasciencesExpertiseService
    {
        private IRepository<DatasciencesExpertise> repository;
        public DatasciencesExpertiseService(IRepository<DatasciencesExpertise> repository)
        {
            this.repository = repository;
        }
        public void DeleteDatasciencesExpertise(int id)
        {
            DatasciencesExpertise datasciencesExpertise = GetDatasciencesExpertise(id);
            repository.Delete(datasciencesExpertise);
            repository.SaveChanges();
        }

        public IEnumerable<DatasciencesExpertise> GetAllDatasciencesExpertise()
        {
            return repository.GetAll();
        }

        public DatasciencesExpertise GetDatasciencesExpertise(int id)
        {
            return repository.Get(id);
        }

        public void InSertDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise)
        {
            repository.Insert(datasciencesExpertise);
        }

        public void UpdateDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise)
        {
            repository.Update(datasciencesExpertise);
        }
    }
}
