using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextDemoService
{
    public interface ISpeechtotextDemoService
    {
        IEnumerable<SpeechtotextDemo> GetAllSpeechtotextDemo();
        SpeechtotextDemo GetSpeechtotextDemo(int id);
        void InsertSpeechtotextDemo(SpeechtotextDemo speechtotextDemo);
        void UpdateSpeechtotextDemo(SpeechtotextDemo speechtotextDemo);
        void DeleteSpeechtotextDemo(int id);
    }
}
