using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.MobileSubscribeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileSubscribeController : ControllerBase
    {
        private readonly IMobileSubscribeService mobileSubscribeService;
        public MobileSubscribeController(IMobileSubscribeService mobileSubscribeService)
        {
            this.mobileSubscribeService = mobileSubscribeService;
        }
        [HttpGet(nameof(GetMobileSubscribe))]
        public IActionResult GetMobileSubscribe(int id)
        {
            var result = mobileSubscribeService.GetMobileSubscribe(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllMobileSubscribe))]
        public IActionResult GetAllMobileSubscribe()
        {
            var result = mobileSubscribeService.GetAllMobileSubscribe();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertMobileSubscribe))]
        public IActionResult InsertMobileSubscribe(MobileSubscribe mobileSubscribe)
        {
            mobileSubscribeService.InsertMobileSubscribe(mobileSubscribe);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateMobileSubscribe))]
        public IActionResult UpdateMobileSubscribe(MobileSubscribe mobileSubscribe)
        {
            mobileSubscribeService.UpdateMobileSubscribe(mobileSubscribe);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteMobileSubscribe))]
        public IActionResult DeleteMobileSubscribe(int id)
        {
            mobileSubscribeService.DeleteMobileSubscribe(id);
            return Ok("Delete success");
        }
    }
}
