using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class TexTSIntro : BaseEntity
    {
        public string ContentIntro { get; set; }
        public string VideoIntro { get; set; }
        public string ImagesIntro { get; set; }
    }
}
