using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.EkycAIBodyService
{
    public interface IEkycAIBodyService
    {
        IEnumerable<EkycAIBody> GetAllEkycAIBody();
        EkycAIBody GetEkycAIBody(int id);
        void InSertEkycAIBody(EkycAIBody ekycAIBody);
        void UpdateEkycAIBody(EkycAIBody ekycAIBody);
        void DeleteEkycAIBody(int id);
    }
}
