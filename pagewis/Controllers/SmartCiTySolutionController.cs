using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SmartCiTySolutionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartCiTySolutionController : ControllerBase
    {
        private readonly ISmartCiTySolutionService smartCiTySolutionService;
        public SmartCiTySolutionController(ISmartCiTySolutionService smartCiTySolutionService)
        {
            this.smartCiTySolutionService = smartCiTySolutionService;
        }
        [HttpGet(nameof(GetSmartCiTySolution))]
        public IActionResult GetSmartCiTySolution(int id)
        {
            var result = smartCiTySolutionService.GetSmartCiTySolution(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSmartCiTySolution))]
        public IActionResult GetAllSmartCiTySolution()
        {
            var result = smartCiTySolutionService.GetAllSmartCiTySolution();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSmartCiTySolution))]
        public IActionResult InsertSmartCiTySolution(SmartCiTySolution smartCiTySolution)
        {
            smartCiTySolutionService.InsertSmartCiTySolution(smartCiTySolution);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSmartCiTySolution))]
        public IActionResult UpdateSmartCiTySolution(SmartCiTySolution smartCiTySolution)
        {
            smartCiTySolutionService.UpdateSmartCiTySolution(smartCiTySolution);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSmartCiTySolution))]
        public IActionResult DeleteSmartCiTySolution(int id)
        {
            smartCiTySolutionService.DeleteSmartCiTySolution(id);
            return Ok("Delete success");
        }
    }
}
