using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.SmartCiTyDigitalServive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartCiTyDigitalController : ControllerBase
    {
        private readonly ISmartCiTyDigitalServive smartCiTyDigitalServive;
        public SmartCiTyDigitalController(ISmartCiTyDigitalServive smartCiTyDigitalServive)
        {
            this.smartCiTyDigitalServive = smartCiTyDigitalServive;
        }
        [HttpGet(nameof(GetSmartCiTyDigital))]
        public IActionResult GetSmartCiTyDigital(int id)
        {
            var result = smartCiTyDigitalServive.GetSmartCiTyDigital(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllSmartCiTyDigital))]
        public IActionResult GetAllSmartCiTyDigital()
        {
            var result = smartCiTyDigitalServive.GetAllSmartCiTyDigital();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSmartCiTyDigital))]
        public IActionResult InsertSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital)
        {
            smartCiTyDigitalServive.InsertSmartCiTyDigital(smartCiTyDigital);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSmartCiTyDigital))]
        public IActionResult UpdateSmartCiTyDigital(SmartCiTyDigital smartCiTyDigital)
        {
            smartCiTyDigitalServive.UpdateSmartCiTyDigital(smartCiTyDigital);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteSmartCiTyDigital))]
        public IActionResult DeleteSmartCiTyDigital(int id)
        {
            smartCiTyDigitalServive.DeleteSmartCiTyDigital(id);
            return Ok("Delete success");
        }
    }
}
