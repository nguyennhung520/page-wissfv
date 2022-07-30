using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.SpeechtotextPricingService
{
    public interface ISpeechtotextPricingService
    {
        IEnumerable<SpeechtotextPricing> GetAllSpeechtotextPricing();
        SpeechtotextPricing GetSpeechtotextPricing(int id);
        void InsertSpeechtotextPricing(SpeechtotextPricing speechtotextPricing);
        void UpdateSpeechtotextPricing(SpeechtotextPricing speechtotextPricing);
        void DeleteSpeechtotextPricing(int id);
    }
}
