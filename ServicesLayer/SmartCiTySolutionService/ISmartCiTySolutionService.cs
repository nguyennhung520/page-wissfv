using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTySolutionService
{
    public interface ISmartCiTySolutionService
    {
        IEnumerable<SmartCiTySolution> GetAllSmartCiTySolution();
        SmartCiTySolution GetSmartCiTySolution(int id);
        void InsertSmartCiTySolution(SmartCiTySolution smartCiTySolution);
        void UpdateSmartCiTySolution(SmartCiTySolution smartCiTySolution);
        void DeleteSmartCiTySolution(int id);
    }
}
