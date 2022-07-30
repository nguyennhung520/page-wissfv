using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SmartCiTyDigitalServive
{
    public interface ISmartCiTyDigitalServive
    {
        IEnumerable<SmartCiTyDigital> GetAllSmartCiTyDigital();
        SmartCiTyDigital GetSmartCiTyDigital(int id);
        void InsertSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital);
        void UpdateSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital);
        void DeleteSmartCiTyDigital(int id);
    }
}
