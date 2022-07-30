using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ConversationPricingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationPricingController : ControllerBase
    {
        private readonly IConversationPricingService conversationPricingService;
        public ConversationPricingController(IConversationPricingService conversationPricingService)
        {
            this.conversationPricingService = conversationPricingService;
        }
        [HttpGet(nameof(GetConversationPricing))]
        public IActionResult GetConversationPricing(int id)
        {
            var result = conversationPricingService.GetConversationPricing(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllConversationPricing))]
        public IActionResult GetAllConversationPricing()
        {
            var result = conversationPricingService.GetAllConversationPricing();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertConversationPricing))]
        public IActionResult InsertConversationPricing(ConversationPricing conversationPricing)
        {
            conversationPricingService.InSertConversationPricing(conversationPricing);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateConversationPricing))]
        public IActionResult UpdateConversationPricing(ConversationPricing conversationPricing)
        {
            conversationPricingService.UpdateConversationPricing(conversationPricing);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteConversationPricing))]
        public IActionResult DeleteConversationPricing(int id)
        {
            conversationPricingService.DeleteConversationPricing(id);
            return Ok("Delete success");
        }
    }
}
