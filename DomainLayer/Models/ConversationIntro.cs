using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ConversationIntro : BaseEntity
    {
        public string ContentConversation { get; set; }
        public string VideoConversation { get; set; }
        public string ButtonWatch { get; set; }
        public string ImagesConversation { get; set; }
    }
}
