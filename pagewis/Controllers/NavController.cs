using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.NavService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavController : ControllerBase
    {
        private readonly INavService navService;
        public NavController(INavService navService)
        {
            this.navService = navService;
        }
        [HttpGet(nameof(GetNav))]
        public IActionResult GetNav(int id)
        {
            var result = navService.GetNav(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllNav))]
        public IActionResult GetAllNav()
        {
            var result = navService.GetAllNav();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertNav))]
        public IActionResult InsertNav(Nav nav)
        {
            navService.InSertNav(nav);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateNav))]
        public IActionResult UpdateNav(Nav nav)
        {
            navService.UpdateNav(nav);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteNav))]
        public IActionResult DeleteNav(int id)
        {
            navService.DeleteNav(id);
            return Ok("Delete success");
        }
    }
}
