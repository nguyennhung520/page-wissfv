using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSDemoService
{
    public interface ITexTSDemoService
    {
        IEnumerable<TexTSDemo> GetAllTexTSDemo();
        TexTSDemo GetTexTSDemo(int id);
        void InsertTexTSDemo(TexTSDemo texTSDemo);
        void UpdateTexTSDemo(TexTSDemo texTSDemo);
        void DeleteTexTSDemo(int id);
    }
}
