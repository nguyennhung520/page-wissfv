using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.DatasciencesDemoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatasciencesDemoController : ControllerBase
    {
        private readonly IDatasciencesDemoService datasciencesDemoService;
        public DatasciencesDemoController(IDatasciencesDemoService datasciencesDemoService)
        {
            this.datasciencesDemoService = datasciencesDemoService;
        }
        [HttpGet(nameof(GetDatasciencesDemo))]
        public IActionResult GetDatasciencesDemo(int id)
        {
            var result = datasciencesDemoService.GetDatasciencesDemo(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllDatasciencesDemo))]
        public IActionResult GetAllDatasciencesDemo()
        {
            var result = datasciencesDemoService.GetAllDatasciencesDemo();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertDatasciencesDemo))]
        public IActionResult InsertDatasciencesDemo(DatasciencesDemo datasciencesDemo)
        {
            datasciencesDemoService.InSertDatasciencesDemo(datasciencesDemo);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateDatasciencesDemo))]
        public IActionResult UpdateDatasciencesDemo(DatasciencesDemo datasciencesDemo)
        {
            datasciencesDemoService.UpdateDatasciencesDemo(datasciencesDemo);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteDatasciencesDemo))]
        public IActionResult DeleteDatasciencesDemo(int id)
        {
            datasciencesDemoService.DeleteDatasciencesDemo(id);
            return Ok("Delete success");
        }
    }
}
