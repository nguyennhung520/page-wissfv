using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextIntroService
{
    public interface ISpeechtotextIntroService
    {
        IEnumerable<SpeechtotextIntro> GetAllSpeechtotextIntro();
        SpeechtotextIntro GetSpeechtotextIntro(int id);
        void InsertSpeechtotextIntro(SpeechtotextIntro speechtotextIntro);
        void UpdateSpeechtotextIntro(SpeechtotextIntro speechtotextIntro);
        void DeleteSpeechtotextIntro(int id);
    }
}
