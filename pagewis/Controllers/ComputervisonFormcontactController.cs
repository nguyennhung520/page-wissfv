using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ComputervisonFormcontactService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputervisonFormcontactController : ControllerBase
    {
        private readonly IComputervisonFormcontactService computervison;
        public ComputervisonFormcontactController(IComputervisonFormcontactService computervisonFormcontactService)
        {
            this.computervison = computervisonFormcontactService;
        }
        [HttpGet(nameof(GetComputervisonFormcontact))]
        public IActionResult GetComputervisonFormcontact(int id)
        {
            var result = computervison.GetComputervisonFormcontact(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllComputervisonFormcontact))]
        public IActionResult GetAllComputervisonFormcontact()
        {
            var result = computervison.GetAllComputervisonFormcontact();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertComputervisonFormcontact))]
        public IActionResult InsertComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact)
        {
            computervison.InSertComputervisonFormcontact(computervisonFormcontact);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateComputervisonFormcontact))]
        public IActionResult UpdateComputervisonFormcontact(ComputervisonFormcontact computervisonFormcontact)
        {
            computervison.UpdateComputervisonFormcontact(computervisonFormcontact);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteComputervisonFormcontact))]
        public IActionResult DeleteComputervisonFormcontact(int id)
        {
            computervison.DeleteComputervisonFormcontact(id);
            return Ok("Delete success");
        }
    }
}
