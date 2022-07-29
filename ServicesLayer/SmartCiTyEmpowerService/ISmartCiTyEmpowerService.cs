using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTyEmpowerService
{
    public interface ISmartCiTyEmpowerService
    {
        IEnumerable<SmartCiTyEmpower> GetAllSmartCiTyEmpower();
        SmartCiTyEmpower GetSmartCiTyEmpower(int id);
        void InsertSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower);
        void UpdateSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower);
        void DeleteSmartCiTyEmpower(int id);
    }
}
