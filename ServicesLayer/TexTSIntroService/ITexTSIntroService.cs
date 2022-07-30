using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSIntroService
{
    public interface ITexTSIntroService
    {
        IEnumerable<TexTSIntro> GetAllTexTSIntro();
        TexTSIntro GetTexTSIntro(int id);
        void InsertTexTSIntro(TexTSIntro texTSIntro);
        void UpdateTexTSIntro(TexTSIntro texTSIntro);
        void DeleteTexTSIntro(int id);
    }
}
