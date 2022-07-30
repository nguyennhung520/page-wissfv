using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIReviewsService
{
    public class RoBertAIReviewsService : IRoBertAIReviewsService
    {
        private IRepository<RoBertAIReviews> repository;
        public RoBertAIReviewsService(IRepository<RoBertAIReviews> repository)
        {
            this.repository = repository;
        }
        public void DeleteRoBertAIReviews(int id)
        {
            RoBertAIReviews roBertAIReviews = GetRoBertAIReviews(id);
            repository.Remove(roBertAIReviews);
            repository.SaveChanges();
        }

        public IEnumerable<RoBertAIReviews> GetAllRoBertAIReviews()
        {
            return repository.GetAll();
        }

        public RoBertAIReviews GetRoBertAIReviews(int id)
        {
            return repository.Get(id);
        }

        public void InsertRoBertAIReviews(RoBertAIReviews roBertAIReviews)
        {
            repository.Insert(roBertAIReviews);
        }

        public void UpdateRoBertAIReviews(RoBertAIReviews roBertAIReviews)
        {
            repository.Update(roBertAIReviews);
        }
    }
}
