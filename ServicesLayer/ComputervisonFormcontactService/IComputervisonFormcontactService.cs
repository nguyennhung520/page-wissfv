using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ComputervisonFormcontactService
{
    public interface IComputervisonFormcontactService
    {
        IEnumerable<ComputervisonFormcontact> GetAllComputervisonFormcontact();
        ComputervisonFormcontact GetComputervisonFormcontact(int id);
        void InSertComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact);
        void UpdateComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact);
        void DeleteComputervisonFormcontact(int id);
    }
}
