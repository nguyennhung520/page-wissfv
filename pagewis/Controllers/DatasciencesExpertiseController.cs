using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.DatasciencesExpertiseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatasciencesExpertiseController : ControllerBase
    {
        private readonly IDatasciencesExpertiseService datasciencesExpertiseService;
        public DatasciencesExpertiseController(IDatasciencesExpertiseService datasciencesExpertiseService)
        {
            this.datasciencesExpertiseService = datasciencesExpertiseService;
        }
        [HttpGet(nameof(GetDatasciencesExpertise))]
        public IActionResult GetDatasciencesExpertise(int id)
        {
            var result = datasciencesExpertiseService.GetDatasciencesExpertise(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllDatasciencesExpertise))]
        public IActionResult GetAllDatasciencesExpertise()
        {
            var result = datasciencesExpertiseService.GetAllDatasciencesExpertise();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertDatasciencesExpertise))]
        public IActionResult InsertDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise)
        {
            datasciencesExpertiseService.InSertDatasciencesExpertise(datasciencesExpertise);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateDatasciencesExpertise))]
        public IActionResult UpdateDatasciencesExpertise(DatasciencesExpertise datasciencesExpertise)
        {
            datasciencesExpertiseService.UpdateDatasciencesExpertise(datasciencesExpertise);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteDatasciencesExpertise))]
        public IActionResult DeleteDatasciencesExpertise(int id)
        {
            datasciencesExpertiseService.DeleteDatasciencesExpertise(id);
            return Ok("Delete success");
        }
    }
}
