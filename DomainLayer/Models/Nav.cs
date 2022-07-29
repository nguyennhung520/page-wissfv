using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class Nav : BaseEntity
    {
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Page { get; set; }
        public Navdrop Navdrop { get; set; }
        
        
    }
}
