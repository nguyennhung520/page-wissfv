using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ConversationDoiTacService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationDoiTacController : ControllerBase
    {
        private readonly IConversationDoiTacService conversationDoiTacService;
        public ConversationDoiTacController(IConversationDoiTacService conversationDoiTacService)
        {
            this.conversationDoiTacService = conversationDoiTacService;
        }
        [HttpGet(nameof(GetConversationDoiTac))]
        public IActionResult GetConversationDoiTac(int id)
        {
            var result = conversationDoiTacService.GetConversationDoiTac(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllConversationDoiTac))]
        public IActionResult GetAllConversationDoiTac()
        {
            var result = conversationDoiTacService.GetAllConversationDoiTac();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertConversationDoiTac))]
        public IActionResult InsertConversationDoiTac(ConversationDoiTac conversationDoiTac)
        {
            conversationDoiTacService.InSertConversationDoiTac(conversationDoiTac);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateConversationDoiTac))]
        public IActionResult UpdateConversationDoiTac(ConversationDoiTac conversationDoiTac)
        {
            conversationDoiTacService.UpdateConversationDoiTac(conversationDoiTac);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteConversationDoiTac))]
        public IActionResult DeleteConversationDoiTac(int id)
        {
            conversationDoiTacService.DeleteConversationDoiTac(id);
            return Ok("Delete success");
        }
    }
}
