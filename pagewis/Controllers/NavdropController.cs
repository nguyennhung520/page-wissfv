using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.NavdropService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavdropController : ControllerBase
    {
        private readonly INavdropService navdropService;
        public NavdropController(INavdropService navdropService)
        {
            this.navdropService = navdropService;
        }
        [HttpGet(nameof(GetNavdrop))]
        public IActionResult GetNavdrop(int id)
        {
            var result = navdropService.GetNavdrop(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllNavdrop))]
        public IActionResult GetAllNavdrop()
        {
            var result = navdropService.GetAllNavdrop();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertNavdrop))]
        public IActionResult InsertNavdrop(Navdrop navdrop)
        {
            navdropService.InsertNavdrop(navdrop);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateNavdrop))]
        public IActionResult UpdateNavdrop(Navdrop navdrop)
        {
            navdropService.UpdateNavdrop(navdrop);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteNavdrop))]
        public IActionResult DeleteNavdrop(int id)
        {
            navdropService.DeleteNavdrop(id);
            return Ok("Delete success");
        }
    }
}
