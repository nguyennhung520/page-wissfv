using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class SpeechtotextIntro : BaseEntity
    {
        public string ContentIntro { get; set; }
        public string VideoIntro { get; set; }
        public string ImagesIntro { get; set; }
    }
}
