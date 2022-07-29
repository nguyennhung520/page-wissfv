using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SmartCiTyEmpowerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartCiTyEmpowerController : ControllerBase
    {
        private readonly ISmartCiTyEmpowerService smartCiTyEmpowerService;
        public SmartCiTyEmpowerController(ISmartCiTyEmpowerService smartCiTyEmpowerService)
        {
            this.smartCiTyEmpowerService = smartCiTyEmpowerService;
        }
        [HttpGet(nameof(GetSmartCiTyEmpower))]
        public IActionResult GetSmartCiTyEmpower(int id)
        {
            var result = smartCiTyEmpowerService.GetSmartCiTyEmpower(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSmartCiTyEmpower))]
        public IActionResult GetAllSmartCiTyEmpower()
        {
            var result = smartCiTyEmpowerService.GetAllSmartCiTyEmpower();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSmartCiTyEmpower))]
        public IActionResult InsertSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower)
        {
            smartCiTyEmpowerService.InsertSmartCiTyEmpower(smartCiTyEmpower);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSmartCiTyEmpower))]
        public IActionResult UpdateSmartCiTyEmpower(SmartCiTyEmpower smartCiTyEmpower)
        {
            smartCiTyEmpowerService.UpdateSmartCiTyEmpower(smartCiTyEmpower);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSmartCiTyEmpower))]
        public IActionResult DeleteSmartCiTyEmpower(int id)
        {
            smartCiTyEmpowerService.DeleteSmartCiTyEmpower(id);
            return Ok("Delete success");
        }
    }
}
