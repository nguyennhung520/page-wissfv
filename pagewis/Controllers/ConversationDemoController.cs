using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ConversationDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationDemoController : ControllerBase
    {
        private readonly IConversationDemoService conversationDemoService;
        public ConversationDemoController(IConversationDemoService conversationDemoService)
        {
            this.conversationDemoService = conversationDemoService;
        }
        [HttpGet(nameof(GetConversationDemo))]
        public IActionResult GetConversationDemo(int id)
        {
            var result = conversationDemoService.GetConversationDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllConversationDemo))]
        public IActionResult GetAllConversationDemo()
        {
            var result = conversationDemoService.GetAllConversationDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertConversationDemo))]
        public IActionResult InsertConversationDemo(ConversationDemo conversationDemo)
        {
            conversationDemoService.InSertConversationDemo(conversationDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateConversationDemo))]
        public IActionResult UpdateConversationDemo(ConversationDemo conversationDemo)
        {
            conversationDemoService.UpdateConversationDemo(conversationDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteConversationDemo))]
        public IActionResult DeleteConversationDemo(int id)
        {
            conversationDemoService.DeleteConversationDemo(id);
            return Ok("Delete success");
        }
    }
}
