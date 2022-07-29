using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.TexTSIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TexTSIntroController : ControllerBase
    {
        private readonly ITexTSIntroService texTSIntroService;
        public TexTSIntroController(ITexTSIntroService texTSIntroService)
        {
            this.texTSIntroService = texTSIntroService;
        }
        [HttpGet(nameof(GetTexTSIntro))]
        public IActionResult GetTexTSIntro(int id)
        {
            var result = texTSIntroService.GetTexTSIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }

        [HttpGet(nameof(GetAllTexTSIntro))]
        public IActionResult GetAllTexTSIntro()
        {
            var result = texTSIntroService.GetAllTexTSIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }

        [HttpPost(nameof(InsertTexTSIntro))]
        public IActionResult InsertTexTSIntro(TexTSIntro texTSIntro)
        {
            texTSIntroService.InsertTexTSIntro(texTSIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateTexTSIntro))]
        public IActionResult UpdateTexTSIntro(TexTSIntro texTSIntro)
        {
            texTSIntroService.UpdateTexTSIntro(texTSIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteTexTSIntro))]
        public IActionResult DeleteTexTSIntro(int id)
        {
            texTSIntroService.DeleteTexTSIntro(id);
            return Ok("Delete success");
        }
    }
}
