using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class ListMenu : BaseEntity 
    {
        public string littleMenu { get; set; }
        public List<MenuGroup> mainMenu { get; set; }
    }
}
