using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ChatbotBlogService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotBlogController : ControllerBase
    {
        private readonly IChatbotBlogService chatbotBlogService;
        public ChatbotBlogController(IChatbotBlogService chatbotBlogService)
        {
            this.chatbotBlogService = chatbotBlogService;
        }
        [HttpGet(nameof(GetChatbotBlog))]
        public IActionResult GetChatbotBlog(int id)
        {
            var result = chatbotBlogService.GetChatbotBlog(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllChatbotBlog))]
        public IActionResult GetAllChatbotBlog()
        {
            var result = chatbotBlogService.GetAllChatbotBlog();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertChatbotBlog))]
        public IActionResult InsertChatbotBlog(ChatbotBlog chatbotBlog)
        {
            chatbotBlogService.InsertChatbotBlog(chatbotBlog);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateChatbotBlog))]
        public IActionResult UpdateChatbotBlog(ChatbotBlog chatbotBlog)
        {
            chatbotBlogService.UpdateChatbotBlog(chatbotBlog);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteChatbotBlog))]
        public IActionResult DeleteChatbotBlog(int id)
        {
            chatbotBlogService.DeleteChatbotBlog(id);
            return Ok("Delete success");
        }
    }
}
