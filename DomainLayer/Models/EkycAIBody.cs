using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class EkycAIBody : BaseEntity
    {
        public string ContentEkyc { get; set; }
        public string VideoEkyc { get; set; }
        public string ButtonEkyc { get; set; }
    }
}
