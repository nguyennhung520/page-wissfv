using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class MobileBacked : BaseEntity
    {
        public string HeadingBacked { get; set; }
        public string ImagesBacked { get; set; }
        public string ContentBacked { get; set; }
        public string TextBacked { get; set; }
        public string IconBacked { get; set; }
    }
}
