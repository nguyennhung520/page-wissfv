using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SpeechtotextIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeechtotextIntroController : ControllerBase
    {
        private readonly ISpeechtotextIntroService speechtotextIntroService;
        public SpeechtotextIntroController(ISpeechtotextIntroService speechtotextIntroService)
        {
            this.speechtotextIntroService = speechtotextIntroService;
        }
        [HttpGet(nameof(GetSpeechtotextIntro))]
        public IActionResult GetSpeechtotextIntro(int id)
        {
            var result = speechtotextIntroService.GetSpeechtotextIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSpeechtotextIntro))]
        public IActionResult GetAllSpeechtotextIntro()
        {
            var result = speechtotextIntroService.GetAllSpeechtotextIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSpeechtotextIntro))]
        public IActionResult InsertSpeechtotextIntro(SpeechtotextIntro speechtotextIntro)
        {
            speechtotextIntroService.InsertSpeechtotextIntro(speechtotextIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSpeechtotextIntro))]
        public IActionResult UpdateSpeechtotextIntro(SpeechtotextIntro speechtotextIntro)
        {
            speechtotextIntroService.UpdateSpeechtotextIntro(speechtotextIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSpeechtotextIntro))]
        public IActionResult DeleteSpeechtotextIntro(int id)
        {
            speechtotextIntroService.DeleteSpeechtotextIntro(id);
            return Ok("Delete success");
        }
    }
}
