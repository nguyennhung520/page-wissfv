using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class Navdrop : BaseEntity
    {
        public int text { get; set; }
        public int Id_nav { get; set; }
        public List<Nav> Contact { get; set; }
    }
}
