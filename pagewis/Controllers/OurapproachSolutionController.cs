using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.OurapproachSolutionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurapproachSolutionController : ControllerBase
    {
        private readonly IOurapproachSolutionService ourapproachSolutionService;
        public OurapproachSolutionController(IOurapproachSolutionService ourapproachSolutionService)
        {
            this.ourapproachSolutionService = ourapproachSolutionService;
        }
        [HttpGet(nameof(GetOurapproachSolution))]
        public IActionResult GetOurapproachSolution(int id)
        {
            var result = ourapproachSolutionService.GetOurapproachSolution(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllOurapproachSolution))]
        public IActionResult GetAllOurapproachSolution()
        {
            var result = ourapproachSolutionService.GetAllOurapproachSolution();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertOurapproachSolution))]
        public IActionResult InsertOurapproachSolution(OurapproachSolution ourapproachSolution)
        {
            ourapproachSolutionService.InsertOurapproachSolution(ourapproachSolution);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateOurapproachSolution))]
        public IActionResult UpdateOurapproachSolution(OurapproachSolution ourapproachSolution)
        {
            ourapproachSolutionService.UpdateOurapproachSolution(ourapproachSolution);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteOurapproachSolution))]
        public IActionResult DeleteOurapproachSolution(int id)
        {
            ourapproachSolutionService.DeleteOurapproachSolution(id);
            return Ok("Delete success");
        }
    }
}
