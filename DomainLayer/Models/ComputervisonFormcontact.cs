using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ComputervisonFormcontact : BaseEntity
    {
        public string HeadingFormcontact { get; set; }
        public string ContentFormcontact { get; set; }
        public string InputFormcontact { get; set; }
    }
}
