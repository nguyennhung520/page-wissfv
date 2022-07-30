using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIReviewsService
{
    public interface IRoBertAIReviewsService
    {
        IEnumerable<RoBertAIReviews> GetAllRoBertAIReviews();
        RoBertAIReviews GetRoBertAIReviews(int id);
        void InsertRoBertAIReviews(RoBertAIReviews roBertAIReviews);
        void UpdateRoBertAIReviews(RoBertAIReviews roBertAIReviews);
        void DeleteRoBertAIReviews(int id);
    }
}
