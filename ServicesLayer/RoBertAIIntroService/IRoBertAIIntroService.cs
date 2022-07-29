using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIIntroService
{
    public interface IRoBertAIIntroService
    {
        IEnumerable<RoBertAIIntro> GetAllRoBertAIIntro();
        RoBertAIIntro GetRoBertAIIntro(int id);
        void InsertRoBertAIIntro(RoBertAIIntro roBertAIIntro);
        void UpdateRoBertAIIntro(RoBertAIIntro roBertAIIntro);
        void DeleteRoBertAIIntro(int id);
    }
}
