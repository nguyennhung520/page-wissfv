using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.DatasciencesDemoService
{
    public interface IDatasciencesDemoService
    {
        IEnumerable<DatasciencesDemo> GetAllDatasciencesDemo();
        DatasciencesDemo GetDatasciencesDemo(int id);
        void InSertDatasciencesDemo(DatasciencesDemo datasciencesDemo);
        void UpdateDatasciencesDemo(DatasciencesDemo datasciencesDemo);
        void DeleteDatasciencesDemo(int id);
    }
}
