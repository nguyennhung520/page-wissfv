using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ConversationPricing : BaseEntity
    {
        public string HeadingPricing { get; set; }
        public string TitlePricing { get; set; }
        public string ListPricing { get; set; }
        public string PricePricing { get; set; }
        public string ButtonPricing { get; set; }
    }
}
