﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class SpeechtotextPricing : BaseEntity
    {
        public string HeadingPricing { get; set; }
        public string titlePricing { get; set; }
        public string ContentPricing { get; set; }
        public string pricePricing { get; set; }
    }
}