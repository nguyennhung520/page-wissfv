using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.RoBertAIPricingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoBertAIPricingController : ControllerBase
    {
        private readonly IRoBertAIPricingService roBertAIPricingService;
        public RoBertAIPricingController(IRoBertAIPricingService roBertAIPricingService)
        {
            this.roBertAIPricingService = roBertAIPricingService;
        }
        [HttpGet(nameof(GetRoBertAIPricing))]
        public IActionResult GetRoBertAIPricing(int id)
        {
            var result = roBertAIPricingService.GetRoBertAIPricing(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllRoBertAIPricing))]
        public IActionResult GetAllRoBertAIPricing()
        {
            var result = roBertAIPricingService.GetAllRoBertAIPricing();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertRoBertAIPricing))]
        public IActionResult InsertRoBertAIPricing(RoBertAIPricing roBertAIPricing)
        {
            roBertAIPricingService.InsertRoBertAIPricing(roBertAIPricing);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateRoBertAIPricing))]
        public IActionResult UpdateRoBertAIPricing(RoBertAIPricing roBertAIPricing)
        {
            roBertAIPricingService.UpdateRoBertAIPricing(roBertAIPricing);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteRoBertAIPricing))]
        public IActionResult DeleteRoBertAIPricing(int id)
        {
            roBertAIPricingService.DeleteRoBertAIPricing(id);
            return Ok("Delete success");
        }
    }
}
