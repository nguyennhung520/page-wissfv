using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class BeehiveFeatures : BaseEntity
    {
        public string HeadingFeatures { get; set; }
        public string ContentFeatures { get; set; }
        public string iconFeatures { get; set; }
        public string titleFeatures { get; set; }
        public string slidesFeatures { get; set; }
    }
}
