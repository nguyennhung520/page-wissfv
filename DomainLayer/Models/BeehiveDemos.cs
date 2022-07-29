using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class BeehiveDemos : BaseEntity
    {
        public string HeadingBeehive { get; set; }
        public string ContentBeehive { get; set; }
        public string imagesBeehive { get; set; }
        public string titletemplate { get; set; }
    }
}
