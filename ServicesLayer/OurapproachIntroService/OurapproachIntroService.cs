using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachIntroService
{
    public class OurapproachIntroService : IOurapproachIntroService
    {
        private IRepository<OurapproachIntro> repository;
        public OurapproachIntroService(IRepository<OurapproachIntro> repository)
        {
            this.repository = repository;
        }
        public void DeleteOurapproachIntro(int id)
        {
            OurapproachIntro ourapproachIntro = GetOurapproachIntro(id);
            repository.Remove(ourapproachIntro);
            repository.SaveChanges();
        }

        public IEnumerable<OurapproachIntro> GetAllOurapproachIntro()
        {
            return repository.GetAll();
        }

        public OurapproachIntro GetOurapproachIntro(int id)
        {
            return repository.Get(id);
        }

        public void InsertOurapproachIntro(OurapproachIntro ourapproachIntro)
        {
            repository.Insert(ourapproachIntro);
        }

        public void UpdateOurapproachIntro(OurapproachIntro ourapproachIntro)
        {
            repository.Update(ourapproachIntro);
        }
    }
}
