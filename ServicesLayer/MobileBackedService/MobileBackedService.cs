using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileBackedService
{
    public class MobileBackedService : IMobileBackedService
    {
        private IRepository<MobileBacked> repository;
        public MobileBackedService(IRepository<MobileBacked> repository)
        {
            this.repository = repository;
        }

        public void DeleteMobileBacked(int id)
        {
            MobileBacked mobileBacked = GetMobileBacked(id);
            repository.Remove(mobileBacked);
            repository.SaveChanges();
        }

        public IEnumerable<MobileBacked> GetAllMobileBacked()
        {
            return repository.GetAll();
        }

        public MobileBacked GetMobileBacked(int id)
        {
            return repository.Get(id);
        }

        public void InsertMobileBacked(MobileBacked mobileBacked)
        {
            repository.Insert(mobileBacked);
        }

        public void UpdateMobileBacked(MobileBacked mobileBacked)
        {
            repository.Update(mobileBacked);
        }
    }
}
