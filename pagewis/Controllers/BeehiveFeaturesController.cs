using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.BeehiveFeaturesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeehiveFeaturesController : ControllerBase
    {
        private readonly IBeehiveFeaturesService beehiveFeaturesService;
        public BeehiveFeaturesController(IBeehiveFeaturesService beehiveFeaturesService)
        {
            this.beehiveFeaturesService = beehiveFeaturesService;
        }
        [HttpGet(nameof(GetBeehiveFeatures))]
        public IActionResult GetBeehiveFeatures(int id)
        {
            var result = beehiveFeaturesService.GetBeehiveFeatures(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllBeehiveFeatures))]
        public IActionResult GetAllBeehiveFeatures()
        {
            var result = beehiveFeaturesService.GetAllBeehiveFeatures();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertBeehiveFeatures))]
        public IActionResult InsertBeehiveFeatures(BeehiveFeatures beehiveFeatures)
        {
            beehiveFeaturesService.InsertBeehiveFeatures(beehiveFeatures);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateBeehiveFeatures))]
        public IActionResult UpdateBeehiveFeatures(BeehiveFeatures beehiveFeatures)
        {
            beehiveFeaturesService.UpdateBeehiveFeatures(beehiveFeatures);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteBeehiveFeatures))]
        public IActionResult DeleteBeehiveFeatures(int id)
        {
            beehiveFeaturesService.DeleteBeehiveFeatures(id);
            return Ok("Delete success");
        }
    }
}
