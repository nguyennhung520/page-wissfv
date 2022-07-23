﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifieDate { get; set; }
    }
}
