using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.RoBertAIPricingService
{
    public interface IRoBertAIPricingService
    {
        IEnumerable<RoBertAIPricing> GetAllRoBertAIPricing();
        RoBertAIPricing GetRoBertAIPricing(int id);
        void InsertRoBertAIPricing(RoBertAIPricing roBertAIPricing);
        void UpdateRoBertAIPricing(RoBertAIPricing roBertAIPricing);
        void DeleteRoBertAIPricing(int id);
    }
}
