using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.OurapproachDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurapproachDemoController : ControllerBase
    {
        private readonly IOurapproachDemoService ourapproachDemoService;
        public OurapproachDemoController(IOurapproachDemoService ourapproachDemoService)
        {
            this.ourapproachDemoService = ourapproachDemoService;
        }
        [HttpGet(nameof(GetOurapproachDemo))]
        public IActionResult GetOurapproachDemo(int id)
        {
            var result = ourapproachDemoService.GetOurapproachDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllOurapproachDemo))]
        public IActionResult GetAllOurapproachDemo()
        {
            var result = ourapproachDemoService.GetAllOurapproachDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertOurapproachDemo))]
        public IActionResult InsertOurapproachDemo(OurapproachDemo ourapproachDemo)
        {
            ourapproachDemoService.InsertOurapproachDemo(ourapproachDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateOurapproachDemo))]
        public IActionResult UpdateOurapproachDemo(OurapproachDemo ourapproachDemo)
        {
            ourapproachDemoService.UpdateOurapproachDemo(ourapproachDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteOurapproachDemo))]
        public IActionResult DeleteOurapproachDemo(int id)
        {
            ourapproachDemoService.DeleteOurapproachDemo(id);
            return Ok("Delete success");
        }
    }
}
