using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.MobileSubscribeService
{
    public interface IMobileSubscribeService
    {
        IEnumerable<MobileSubscribe> GetAllMobileSubscribe();
        MobileSubscribe GetMobileSubscribe(int id);
        void InsertMobileSubscribe(MobileSubscribe mobileSubscribe);
        void UpdateMobileSubscribe(MobileSubscribe mobileSubscribe);
        void DeleteMobileSubscribe(int id);
    }
}
