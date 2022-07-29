using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BeehiveDemosService
{
    public class BeehiveDemosService : IBeehiveDemosService
    {
        private IRepository<BeehiveDemos> repository;
        public BeehiveDemosService(IRepository<BeehiveDemos> repository)
        {
            this.repository = repository;
        }

        public void DeleteBeehiveDemos(int id)
        {
            BeehiveDemos beehiveDemos = GetBeehiveDemos(id);
            repository.Remove(beehiveDemos);
            repository.SaveChanges();
        }

        public IEnumerable<BeehiveDemos> GetAllBeehiveDemos()
        {
            return repository.GetAll();
        }

        public BeehiveDemos GetBeehiveDemos(int id)
        {
            return repository.Get(id);
        }

        public void InsertBeehiveDemos(BeehiveDemos beehiveDemos)
        {
            repository.Insert(beehiveDemos);
        }

        public void UpdateBeehiveDemos(BeehiveDemos beehiveDemos)
        {
            repository.Update(beehiveDemos);
        }
    }
}
