using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ListFooterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListFooterController : ControllerBase
    {
        private readonly IListFooterService listFooterService;
        public ListFooterController(IListFooterService listFooterService)
        {
            this.listFooterService = listFooterService;
        }
        [HttpGet(nameof(GetListFooter))]
        public IActionResult GetListFooter(int id)
        {
            var result = listFooterService.GetListFooter(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllListFooter))]
        public IActionResult GetAllListFooter()
        {
            var result = listFooterService.GetAllListFooter();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertListFooter))]
        public IActionResult InsertListFooter(ListFooter listFooter)
        {
            listFooterService.InSertListFooter(listFooter);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateListFooter))]
        public IActionResult UpdateListFooter(ListFooter listFooter)
        {
            listFooterService.UpdateListFooter(listFooter);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteListFooter))]
        public IActionResult DeleteListFooter(int id)
        {
            listFooterService.DeleteListFooter(id);
            return Ok("Delete success");
        }
    }
}
