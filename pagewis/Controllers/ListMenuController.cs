using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.listMenuService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListMenuController : ControllerBase
    {
        private readonly IlistMenuService listMenuService;
        public ListMenuController(IlistMenuService listMenuService)
        {
            this.listMenuService = listMenuService;
        }
        [HttpGet(nameof(GetListMenu))]
        public IActionResult GetListMenu(int id)
        {
            var result = listMenuService.GetListMenu(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllListMenu))]
        public IActionResult GetAllListMenu()
        {
            var result = listMenuService.GetAllListMenu();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertListMenu))]
        public IActionResult InsertListMenu(ListMenu listMenu)
        {
            listMenuService.InSertListMenu(listMenu);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateListMenu))]
        public IActionResult UpdateListMenu(ListMenu listMenu)
        {
            listMenuService.UpdateListMenu(listMenu);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteListMenu))]
        public IActionResult DeleteListMenu(int id)
        {
            listMenuService.DeleteListMenu(id);
            return Ok("Delete success");
        }
    }
}
