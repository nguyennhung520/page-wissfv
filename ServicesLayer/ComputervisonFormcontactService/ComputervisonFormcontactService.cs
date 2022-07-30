using DomainLayer.Model;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ComputervisonFormcontactService
{
    public class ComputervisonFormcontactService : IComputervisonFormcontactService
    {
        private IRepository<ComputervisonFormcontact> repository;
        public ComputervisonFormcontactService(IRepository<ComputervisonFormcontact> repository)
        {
            this.repository = repository;
        }
        public void DeleteComputervisonFormcontact(int id)
        {
            ComputervisonFormcontact computervisonFormcontact = GetComputervisonFormcontact(id);
            repository.Delete(computervisonFormcontact);
            repository.SaveChanges();
        }

        public IEnumerable<ComputervisonFormcontact> GetAllComputervisonFormcontact()
        {
            return repository.GetAll();
        }

        public ComputervisonFormcontact GetComputervisonFormcontact(int id)
        {
            return repository.Get(id);
        }

        public void InSertComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact)
        {
            repository.Insert(computervisonFormcontact);
        }

        public void UpdateComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact)
        {
            repository.Update(computervisonFormcontact);
        }
    }
}
