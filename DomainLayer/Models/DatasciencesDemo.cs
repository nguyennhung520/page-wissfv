using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class DatasciencesDemo : BaseEntity
    {
        public string ContentData { get; set; }
        public string VideoData { get; set; }
        public string ButtonStarted { get; set; }
        public string ImagesData { get; set; }
    }
}
