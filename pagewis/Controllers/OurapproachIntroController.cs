using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.OurapproachIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurapproachIntroController : ControllerBase
    {
        private readonly IOurapproachIntroService ourapproachIntroService;
        public OurapproachIntroController(IOurapproachIntroService ourapproachIntroService)
        {
            this.ourapproachIntroService = ourapproachIntroService;
        }
        [HttpGet(nameof(GetOurapproachIntro))]
        public IActionResult GetOurapproachIntro(int id)
        {
            var result = ourapproachIntroService.GetOurapproachIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllOurapproachIntro))]
        public IActionResult GetAllOurapproachIntro()
        {
            var result = ourapproachIntroService.GetAllOurapproachIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertOurapproachIntro))]
        public IActionResult InsertOurapproachIntro(OurapproachIntro ourapproachIntro)
        {
            ourapproachIntroService.InsertOurapproachIntro(ourapproachIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateOurapproachIntro))]
        public IActionResult UpdateOurapproachIntro(OurapproachIntro ourapproachIntro)
        {
            ourapproachIntroService.UpdateOurapproachIntro(ourapproachIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteOurapproachIntro))]
        public IActionResult DeleteOurapproachIntro(int id)
        {
            ourapproachIntroService.DeleteOurapproachIntro(id);
            return Ok("Delete success");
        }
    }
}
