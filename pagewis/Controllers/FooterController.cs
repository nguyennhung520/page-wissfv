using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.FooterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly IFooterService footerService;
        public FooterController(IFooterService footerService)
        {
            this.footerService = footerService;
        }
        [HttpGet(nameof(GetFooter))]
        public IActionResult GetFooter(int id)
        {
            var result = footerService.GetFooter(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllFooter))]
        public IActionResult GetAllFooter()
        {
            var result = footerService.GetAllFooter();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertFooter))]
        public IActionResult InsertFooter(Footer footer)
        {
            footerService.InSertFooter(footer);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateFooter))]
        public IActionResult UpdateFooter(Footer footer)
        {
            footerService.UpdateFooter(footer);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteFooter))]
        public IActionResult DeleteFooter(int id)
        {
            footerService.DeleteFooter(id);
            return Ok("Delete success");
        }
    }
}
