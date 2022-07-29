using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ChatbotBlog : BaseEntity
    {
        public string headingBlog { get; set; }
        public string ImagesBlog { get; set; }
        public string ContentBlog { get; set; }
        public string TitleBlog { get; set; }
        public string MobileBlog { get; set; }
        public string EmailBlog { get; set; }
    }
}
