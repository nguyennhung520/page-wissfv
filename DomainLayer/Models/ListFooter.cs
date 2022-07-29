using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class ListFooter : BaseEntity
    {
        public string Logo_ListFooter { get; set; }
        public string Title_ListFooter { get; set; }
        public List<Footer> Title_Footer { get; set; }
    }
}
