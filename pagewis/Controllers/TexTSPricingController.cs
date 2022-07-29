using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.TexTSPricingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TexTSPricingController : ControllerBase
    {
        private readonly ITexTSPricingService texTSPricingService;
        public TexTSPricingController(ITexTSPricingService texTSPricingService)
        {
            this.texTSPricingService = texTSPricingService;
        }
        [HttpGet(nameof(GetTexTSPricing))]
        public IActionResult GetTexTSPricing(int id)
        {
            var result = texTSPricingService.GetTexTSPricing(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllTexTSPricing))]
        public IActionResult GetAllTexTSPricing()
        {
            var result = texTSPricingService.GetAllTexTSPricing();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertTexTSPricing))]
        public IActionResult InsertTexTSPricing(TexTSPricing texTSPricing)
        {
            texTSPricingService.InsertTexTSPricing(texTSPricing);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateTexTSPricing))]
        public IActionResult UpdateTexTSPricing(TexTSPricing texTSPricing)
        {
            texTSPricingService.UpdateTexTSPricing(texTSPricing);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteTexTSPricing))]
        public IActionResult DeleteTexTSPricing(int id)
        {
            texTSPricingService.DeleteTexTSPricing(id);
            return Ok("Delete success");
        }
    }
}
