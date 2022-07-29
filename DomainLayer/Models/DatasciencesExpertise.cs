using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class DatasciencesExpertise : BaseEntity
    {
        public string HeadingExpertise { get; set; }
        public string ContentExpertise { get; set; }
        public string TitleExpertise { get; set; }
        public string IconExpertise { get; set; }
        public string ButtonExpertise { get; set; }
    }
}
