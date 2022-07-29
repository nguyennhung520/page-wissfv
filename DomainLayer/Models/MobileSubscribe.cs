using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class MobileSubscribe : BaseEntity
    {
        public string HeadingSubscribe { get; set; }
        public string InputSubscribe { get; set; }
        public string ButtonSubscribe { get; set; }
        public string IconSubscribe { get; set; }
    }
}
