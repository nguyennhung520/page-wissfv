using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class MenuGroup : BaseEntity 
    {
        public string mainMenu { get; set; }
        public string Images_menuGroup { get; set; }
        public ListMenu listMenu { get; set; }
    }
}
