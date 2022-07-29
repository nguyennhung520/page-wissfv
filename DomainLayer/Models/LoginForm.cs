using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Models
{
    public class LoginForm : BaseEntity
    {
        public string UserName { get; set; }
        public string PassUser { get; set; }
    }
}
