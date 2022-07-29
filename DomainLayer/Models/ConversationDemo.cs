using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ConversationDemo : BaseEntity
    {
        public string HeadingConversation { get; set; }
        public string ImagesConversation { get; set; }
        public string Buttonstart { get; set; }
        public string ButtonDemo { get; set; }
    }
}
