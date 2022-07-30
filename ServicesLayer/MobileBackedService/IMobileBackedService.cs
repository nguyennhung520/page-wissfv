using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileBackedService
{
    public interface IMobileBackedService
    {
        IEnumerable<MobileBacked> GetAllMobileBacked();
        MobileBacked GetMobileBacked(int id);
        void InsertMobileBacked(MobileBacked mobileBacked);
        void UpdateMobileBacked(MobileBacked mobileBacked);
        void DeleteMobileBacked(int id);
    }
}
