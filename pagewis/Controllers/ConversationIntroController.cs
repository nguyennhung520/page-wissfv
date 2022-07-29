using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ConversationIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationIntroController : ControllerBase
    {
        private readonly IConversationIntroService conversationIntroService;
        public ConversationIntroController(IConversationIntroService conversationIntroService)
        {
            this.conversationIntroService = conversationIntroService;
        }
        [HttpGet(nameof(GetConversationIntro))]
        public IActionResult GetConversationIntro(int id)
        {
            var result = conversationIntroService.GetConversationIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllConversationIntro))]
        public IActionResult GetAllConversationIntro()
        {
            var result = conversationIntroService.GetAllConversationIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertConversationIntro))]
        public IActionResult InsertConversationIntro(ConversationIntro conversationIntro)
        {
            conversationIntroService.InSertConversationIntro(conversationIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateConversationIntro))]
        public IActionResult UpdateConversationIntro(ConversationIntro conversationIntro)
        {
            conversationIntroService.UpdateConversationIntro(conversationIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteConversationIntro))]
        public IActionResult DeleteConversationIntro(int id)
        {
            conversationIntroService.DeleteConversationIntro(id);
            return Ok("Delete success");
        }
    }
}
