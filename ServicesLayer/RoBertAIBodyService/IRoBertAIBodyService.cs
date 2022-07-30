using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIBodyService
{
    public interface IRoBertAIBodyService
    {
        IEnumerable<RoBertAIBody> GetAllRoBertAIBody();
        RoBertAIBody GetRoBertAIBody(int id);
        void InsertRoBertAIBody(RoBertAIBody roBertAIBody);
        void UpdateRoBertAIBody(RoBertAIBody roBertAIBody);
        void DeleteRoBertAIBody(int id);
    }
}
