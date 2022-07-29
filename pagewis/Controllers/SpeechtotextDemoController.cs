using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SpeechtotextDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeechtotextDemoController : ControllerBase
    {
        private readonly ISpeechtotextDemoService speechtotextDemoService;
        public SpeechtotextDemoController(ISpeechtotextDemoService speechtotextDemoService)
        {
            this.speechtotextDemoService = speechtotextDemoService;
        }
        [HttpGet(nameof(GetSpeechtotextDemo))]
        public IActionResult GetSpeechtotextDemo(int id)
        {
            var result = speechtotextDemoService.GetSpeechtotextDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSpeechtotextDemo))]
        public IActionResult GetAllSpeechtotextDemo()
        {
            var result = speechtotextDemoService.GetAllSpeechtotextDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSpeechtotextDemo))]
        public IActionResult InsertSpeechtotextDemo(SpeechtotextDemo speechtotextDemo)
        {
            speechtotextDemoService.InsertSpeechtotextDemo(speechtotextDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSpeechtotextDemo))]
        public IActionResult UpdateSpeechtotextDemo(SpeechtotextDemo speechtotextDemo)
        {
            speechtotextDemoService.UpdateSpeechtotextDemo(speechtotextDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSpeechtotextDemo))]
        public IActionResult DeleteSpeechtotextDemo(int id)
        {
            speechtotextDemoService.DeleteSpeechtotextDemo(id);
            return Ok("Delete success");
        }
    }
}
