using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.BeehiveDemosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeehiveDemosController : ControllerBase
    {
        private readonly IBeehiveDemosService beehiveDemosService;
        public BeehiveDemosController(IBeehiveDemosService beehiveDemosService)
        {
            this.beehiveDemosService = beehiveDemosService;
        }
        [HttpGet(nameof(GetBeehiveDemos))]
        public IActionResult GetBeehiveDemos(int id)
        {
            var result = beehiveDemosService.GetBeehiveDemos(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllBeehiveDemos))]
        public IActionResult GetAllBeehiveDemos()
        {
            var result = beehiveDemosService.GetAllBeehiveDemos();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertBeehiveDemos))]
        public IActionResult InsertBeehiveDemos(BeehiveDemos beehiveDemos)
        {
            beehiveDemosService.InsertBeehiveDemos(beehiveDemos);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateBeehiveDemos))]
        public IActionResult UpdateBeehiveDemos(BeehiveDemos beehiveDemos)
        {
            beehiveDemosService.UpdateBeehiveDemos(beehiveDemos);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteBeehiveDemos))]
        public IActionResult DeleteBeehiveDemos(int id)
        {
            beehiveDemosService.DeleteBeehiveDemos(id);
            return Ok("Delete success");
        }
    }
}
