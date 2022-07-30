using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.DatasciencesDemoService
{
    public class DatasciencesDemoService : IDatasciencesDemoService
    {
        private IRepository<DatasciencesDemo> repository;
        public DatasciencesDemoService(IRepository<DatasciencesDemo> repository)
        {
            this.repository = repository;
        }
        public void DeleteDatasciencesDemo(int id)
        {
            DatasciencesDemo datasciencesDemo = GetDatasciencesDemo(id);
            repository.Delete(datasciencesDemo);
            repository.SaveChanges();
        }

        public IEnumerable<DatasciencesDemo> GetAllDatasciencesDemo()
        {
            return repository.GetAll();
        }

        public DatasciencesDemo GetDatasciencesDemo(int id)
        {
            return repository.Get(id);
        }

        public void InSertDatasciencesDemo(DatasciencesDemo datasciencesDemo)
        {
            repository.Insert(datasciencesDemo);
        }

        public void UpdateDatasciencesDemo(DatasciencesDemo datasciencesDemo)
        {
            repository.Update(datasciencesDemo);
        }
    }
}
