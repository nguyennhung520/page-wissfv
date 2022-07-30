using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ChatbotRelatedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotRelatedController : ControllerBase
    {
        private readonly IChatbotRelatedService chatbotRelatedService;
        public ChatbotRelatedController(IChatbotRelatedService chatbotRelatedService)
        {
            this.chatbotRelatedService = chatbotRelatedService;
        }
        [HttpGet(nameof(GetChatbotRelated))]
        public IActionResult GetChatbotRelated(int id)
        {
            var result = chatbotRelatedService.GetChatbotRelated(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllChatbotRelated))]
        public IActionResult GetAllChatbotRelated()
        {
            var result = chatbotRelatedService.GetAllChatbotRelated();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertChatbotRelated))]
        public IActionResult InsertChatbotRelated(ChatbotRelated chatbotRelated)
        {
            chatbotRelatedService.InSertChatbotRelated(chatbotRelated);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateChatbotRelated))]
        public IActionResult UpdateChatbotRelated(ChatbotRelated chatbotRelated)
        {
            chatbotRelatedService.UpdateChatbotRelated(chatbotRelated);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteChatbotRelated))]
        public IActionResult DeleteChatbotRelated(int id)
        {
            chatbotRelatedService.DeleteChatbotRelated(id);
            return Ok("Delete success");
        }
    }
}
