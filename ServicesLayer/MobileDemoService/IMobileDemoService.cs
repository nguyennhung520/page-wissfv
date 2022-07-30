using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileDemoService
{
    public interface IMobileDemoService
    {
        IEnumerable<MobileDemo> GetAllMobileDemo();
        MobileDemo GetMobileDemo(int id);
        void InsertMobileDemo(MobileDemo mobileDemo);
        void UpdateMobileDemo(MobileDemo mobileDemo);
        void DeleteMobileDemo(int id);
    }
}
