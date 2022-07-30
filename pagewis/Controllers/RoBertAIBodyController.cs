using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.RoBertAIBodyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoBertAIBodyController : ControllerBase
    {
        private readonly IRoBertAIBodyService roBertAIBodyService;
        public RoBertAIBodyController(IRoBertAIBodyService roBertAIBodyService)
        {
            this.roBertAIBodyService = roBertAIBodyService;
        }
        [HttpGet(nameof(GetRoBertAIBody))]
        public IActionResult GetRoBertAIBody(int id)
        {
            var result = roBertAIBodyService.GetRoBertAIBody(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllRoBertAIBody))]
        public IActionResult GetAllRoBertAIBody()
        {
            var result = roBertAIBodyService.GetAllRoBertAIBody();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertRoBertAIBody))]
        public IActionResult InsertRoBertAIBody(RoBertAIBody roBertAIBody)
        {
            roBertAIBodyService.InsertRoBertAIBody(roBertAIBody);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateRoBertAIBody))]
        public IActionResult UpdateRoBertAIBody(RoBertAIBody roBertAIBody)
        {
            roBertAIBodyService.UpdateRoBertAIBody(roBertAIBody);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteRoBertAIBody))]
        public IActionResult DeleteRoBertAIBody(int id)
        {
            roBertAIBodyService.DeleteRoBertAIBody(id);
            return Ok("Delete success");
        }
    }
}
