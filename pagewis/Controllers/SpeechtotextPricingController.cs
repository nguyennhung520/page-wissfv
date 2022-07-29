using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SpeechtotextPricingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeechtotextPricingController : ControllerBase
    {
        private readonly ISpeechtotextPricingService speechtotextPricingService;
        public SpeechtotextPricingController(ISpeechtotextPricingService speechtotextPricingService)
        {
            this.speechtotextPricingService = speechtotextPricingService;
        }
        [HttpGet(nameof(GetSpeechtotextPricing))]
        public IActionResult GetSpeechtotextPricing(int id)
        {
            var result = speechtotextPricingService.GetSpeechtotextPricing(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSpeechtotextPricing))]
        public IActionResult GetAllSpeechtotextPricing()
        {
            var result = speechtotextPricingService.GetAllSpeechtotextPricing();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSpeechtotextPricing))]
        public IActionResult InsertSpeechtotextPricing(SpeechtotextPricing speechtotextPricing)
        {
            speechtotextPricingService.InsertSpeechtotextPricing(speechtotextPricing);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSpeechtotextPricing))]
        public IActionResult UpdateSpeechtotextPricing(SpeechtotextPricing speechtotextPricing)
        {
            speechtotextPricingService.UpdateSpeechtotextPricing(speechtotextPricing);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSpeechtotextPricing))]
        public IActionResult DeleteSpeechtotextPricing(int id)
        {
            speechtotextPricingService.DeleteSpeechtotextPricing(id);
            return Ok("Delete success");
        }
    }
}
