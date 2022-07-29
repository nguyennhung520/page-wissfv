using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.MobileBackedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileBackedController : ControllerBase
    {
        private readonly IMobileBackedService mobileBackedService;
        public MobileBackedController(IMobileBackedService mobileBackedService)
        {
            this.mobileBackedService = mobileBackedService;
        }
        [HttpGet(nameof(GetMobileBacked))]
        public IActionResult GetMobileBacked(int id)
        {
            var result = mobileBackedService.GetMobileBacked(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllMobileBacked))]
        public IActionResult GetAllMobileBacked()
        {
            var result = mobileBackedService.GetAllMobileBacked();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertMobileBacked))]
        public IActionResult InsertMobileBacked(MobileBacked mobileBacked)
        {
            mobileBackedService.InsertMobileBacked(mobileBacked);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateMobileBacked))]
        public IActionResult UpdateMobileBacked(MobileBacked mobileBacked)
        {
            mobileBackedService.UpdateMobileBacked(mobileBacked);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteMobileBacked))]
        public IActionResult DeleteMobileBacked(int id)
        {
            mobileBackedService.DeleteMobileBacked(id);
            return Ok("Delete success");
        }
    }
}
