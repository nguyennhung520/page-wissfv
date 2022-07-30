using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.MobileDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileDemoController : ControllerBase
    {
        private readonly IMobileDemoService mobileDemoService;
        public MobileDemoController(IMobileDemoService mobileDemoService)
        {
            this.mobileDemoService = mobileDemoService;
        }
        [HttpGet(nameof(GetMobileDemo))]
        public IActionResult GetMobileDemo(int id)
        {
            var result = mobileDemoService.GetMobileDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllMobileDemo))]
        public IActionResult GetAllMobileDemo()
        {
            var result = mobileDemoService.GetAllMobileDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertMobileDemo))]
        public IActionResult InsertMobileDemo(MobileDemo mobileDemo)
        {
            mobileDemoService.InsertMobileDemo(mobileDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateMobileDemo))]
        public IActionResult UpdateMobileDemo(MobileDemo mobileDemo)
        {
            mobileDemoService.UpdateMobileDemo(mobileDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteMobileDemo))]
        public IActionResult DeleteMobileDemo(int id)
        {
            mobileDemoService.DeleteMobileDemo(id);
            return Ok("Delete success");
        }
    }
}
