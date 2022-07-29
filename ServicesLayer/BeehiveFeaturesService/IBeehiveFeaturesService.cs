using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.BeehiveFeaturesService
{
    public interface IBeehiveFeaturesService
    {
        IEnumerable<BeehiveFeatures> GetAllBeehiveFeatures();
        BeehiveFeatures GetBeehiveFeatures(int id);
        void InsertBeehiveFeatures(BeehiveFeatures beehiveFeatures);
        void UpdateBeehiveFeatures(BeehiveFeatures beehiveFeatures);
        void DeleteBeehiveFeatures(int id);
    }
}
