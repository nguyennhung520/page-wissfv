using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BeehiveFeaturesService
{
    public class BeehiveFeaturesService : IBeehiveFeaturesService
    {
        private IRepository<BeehiveFeatures> repository;
        public BeehiveFeaturesService(IRepository<BeehiveFeatures> repository)
        {
            this.repository = repository;
        }

        public void DeleteBeehiveFeatures(int id)
        {
            BeehiveFeatures beehiveFeatures = GetBeehiveFeatures(id);
            repository.Remove(beehiveFeatures);
            repository.SaveChanges();
        }

        public IEnumerable<BeehiveFeatures> GetAllBeehiveFeatures()
        {
            return repository.GetAll();
        }

        public BeehiveFeatures GetBeehiveFeatures(int id)
        {
            return repository.Get(id);
        }

        public void InsertBeehiveFeatures(BeehiveFeatures beehiveFeatures)
        {
            repository.Insert(beehiveFeatures);
        }

        public void UpdateBeehiveFeatures(BeehiveFeatures beehiveFeatures)
        {
            repository.Update(beehiveFeatures);
        }
    }
}
