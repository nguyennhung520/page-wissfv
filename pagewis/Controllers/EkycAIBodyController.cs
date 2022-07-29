using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.EkycAIBodyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EkycAIBodyController : ControllerBase
    {
        private readonly IEkycAIBodyService ekycAIBodyService;
        public EkycAIBodyController(IEkycAIBodyService ekycAIBodyService)
        {
            this.ekycAIBodyService = ekycAIBodyService;
        }
        [HttpGet(nameof(GetEkycAIBody))]
        public IActionResult GetEkycAIBody(int id)
        {
            var result = ekycAIBodyService.GetEkycAIBody(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllEkycAIBody))]
        public IActionResult GetAllEkycAIBody()
        {
            var result = ekycAIBodyService.GetAllEkycAIBody();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertEkycAIBody))]
        public IActionResult InsertEkycAIBody(EkycAIBody ekycAIBody)
        {
            ekycAIBodyService.InSertEkycAIBody(ekycAIBody);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateEkycAIBody))]
        public IActionResult UpdateEkycAIBody(EkycAIBody ekycAIBody)
        {
            ekycAIBodyService.UpdateEkycAIBody(ekycAIBody);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteEkycAIBody))]
        public IActionResult DeleteEkycAIBody(int id)
        {
            ekycAIBodyService.DeleteEkycAIBody(id);
            return Ok("Delete success");
        }
    }
}
