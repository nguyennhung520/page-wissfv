using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachSolutionService
{
    public class OurapproachSolutionService : IOurapproachSolutionService
    {
        private IRepository<OurapproachSolution> repository;
        public OurapproachSolutionService(IRepository<OurapproachSolution> repository)
        {
            this.repository = repository;
        }
        public void DeleteOurapproachSolution(int id)
        {
            OurapproachSolution ourapproachSolution = GetOurapproachSolution(id);
            repository.Remove(ourapproachSolution);
            repository.SaveChanges();
        }

        public IEnumerable<OurapproachSolution> GetAllOurapproachSolution()
        {
            return repository.GetAll();
        }

        public OurapproachSolution GetOurapproachSolution(int id)
        {
            return repository.Get(id);
        }

        public void InsertOurapproachSolution(OurapproachSolution ourapproachSolution)
        {
            repository.Insert(ourapproachSolution);
        }

        public void UpdateOurapproachSolution(OurapproachSolution ourapproachSolution)
        {
            repository.Update(ourapproachSolution);
        }
    }
}
