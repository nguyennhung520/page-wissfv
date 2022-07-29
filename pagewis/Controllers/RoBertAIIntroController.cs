using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.RoBertAIIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoBertAIIntroController : ControllerBase
    {
        private readonly IRoBertAIIntroService roBertAIIntroService;
        public RoBertAIIntroController(IRoBertAIIntroService roBertAIIntroService)
        {
            this.roBertAIIntroService = roBertAIIntroService;
        }
        [HttpGet(nameof(GetRoBertAIIntro))]
        public IActionResult GetRoBertAIIntro(int id)
        {
            var result = roBertAIIntroService.GetRoBertAIIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllRoBertAIIntro))]
        public IActionResult GetAllRoBertAIIntro()
        {
            var result = roBertAIIntroService.GetAllRoBertAIIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertRoBertAIIntro))]
        public IActionResult InsertRoBertAIIntro(RoBertAIIntro roBertAIIntro)
        {
            roBertAIIntroService.InsertRoBertAIIntro(roBertAIIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateRoBertAIIntro))]
        public IActionResult UpdateRoBertAIIntro(RoBertAIIntro roBertAIIntro)
        {
            roBertAIIntroService.UpdateRoBertAIIntro(roBertAIIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteRoBertAIIntro))]
        public IActionResult DeleteRoBertAIIntro(int id)
        {
            roBertAIIntroService.DeleteRoBertAIIntro(id);
            return Ok("Delete success");
        }
    }
}
