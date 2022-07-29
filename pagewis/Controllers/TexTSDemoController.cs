using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ContactService;
using ServicesLayer.TexTSDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TexTSDemoController : ControllerBase
    {
        private readonly ITexTSDemoService texTSDemoService;
        public TexTSDemoController(ITexTSDemoService texTSDemoService)
        {
            this.texTSDemoService = texTSDemoService;
        }
        [HttpGet(nameof(GetTexTSDemo))]
        public IActionResult GetTexTSDemo(int id)
        {
            var result = texTSDemoService.GetTexTSDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllTexTSDemo))]
        public IActionResult GetAllTexTSDemo()
        {
            var result = texTSDemoService.GetAllTexTSDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertTexTSDemo))]
        public IActionResult InsertTexTSDemo(TexTSDemo texTSDemo)
        {
            texTSDemoService.InsertTexTSDemo(texTSDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateTexTSDemo))]
        public IActionResult UpdateTexTSDemo(TexTSDemo texTSDemo)
        {
            texTSDemoService.UpdateTexTSDemo(texTSDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteTexTSDemo))]
        public IActionResult DeleteTexTSDemo(int id)
        {
            texTSDemoService.DeleteTexTSDemo(id);
            return Ok("Delete success");
        }
    }
}
