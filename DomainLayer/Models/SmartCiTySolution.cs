using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class SmartCiTySolution : BaseEntity
    {
        public string HeadingSolution { get; set; }
        public string LinkSolution { get; set; }
        public string ImagesSolution { get; set; }
        public string TitleSolution { get; set; }
        public string ContentSolution { get; set; }
    }
}
