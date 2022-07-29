using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BeehiveDemosService
{
    public interface IBeehiveDemosService
    {
        IEnumerable<BeehiveDemos> GetAllBeehiveDemos();
        BeehiveDemos GetBeehiveDemos(int id);
        void InsertBeehiveDemos(BeehiveDemos beehiveDemos);
        void UpdateBeehiveDemos(BeehiveDemos beehiveDemos);
        void DeleteBeehiveDemos(int id);
    }
}
