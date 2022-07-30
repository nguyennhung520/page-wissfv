using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class Footer : BaseEntity
    {
        public string Logo_Footer { get; set; }
        public string Title_Footer { get; set; }
        public ListFooter ListFooter { get; set; }
        public Contact Contact { get; set; }
    }
}
