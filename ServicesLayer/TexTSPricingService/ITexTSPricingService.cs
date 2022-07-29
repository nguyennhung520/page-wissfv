using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.TexTSPricingService
{
    public interface ITexTSPricingService
    {
        IEnumerable<TexTSPricing> GetAllTexTSPricing();
        TexTSPricing GetTexTSPricing(int id);
        void InsertTexTSPricing(TexTSPricing texTSPricing);
        void UpdateTexTSPricing(TexTSPricing texTSPricing);
        void DeleteTexTSPricing(int id);
    }
}
