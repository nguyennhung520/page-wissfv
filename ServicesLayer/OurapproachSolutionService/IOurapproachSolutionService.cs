using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachSolutionService
{
    public interface IOurapproachSolutionService
    {
        IEnumerable<OurapproachSolution> GetAllOurapproachSolution();
        OurapproachSolution GetOurapproachSolution(int id);
        void InsertOurapproachSolution(OurapproachSolution ourapproachSolution);
        void UpdateOurapproachSolution(OurapproachSolution ourapproachSolution);
        void DeleteOurapproachSolution(int id);
    }
}
