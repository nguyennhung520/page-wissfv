using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Model
{
    public class ConversationDoiTac : BaseEntity
    {
        public string TitleConversation { get; set; }
        public string ImagesConversation { get; set; }
        public string ButtonLink { get; set; }
    }
}
