using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.DatasciencesExpertiseService
{
    public interface IDatasciencesExpertiseService
    {
        IEnumerable<DatasciencesExpertise> GetAllDatasciencesExpertise();
        DatasciencesExpertise GetDatasciencesExpertise(int id);
        void InSertDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise);
        void UpdateDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise);
        void DeleteDatasciencesExpertise(int id);
    }
}
