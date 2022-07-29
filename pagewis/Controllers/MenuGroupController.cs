using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.MenuGroupService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuGroupController : ControllerBase
    {
        private readonly IMenuGroupService menuGroupService;
        public MenuGroupController(IMenuGroupService menuGroupService)
        {
            this.menuGroupService = menuGroupService;
        }
        [HttpGet(nameof(GetMenuGroup))]
        public IActionResult GetMenuGroup(int id)
        {
            var result = menuGroupService.GetMenuGroup(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllMenuGroup))]
        public IActionResult GetAllMenuGroup()
        {
            var result = menuGroupService.GetAllMenuGroup();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertMenuGroup))]
        public IActionResult InsertMenuGroup(MenuGroup menuGroup)
        {
            menuGroupService.InSertMenuGroup(menuGroup);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateMenuGroup))]
        public IActionResult UpdateMenuGroup(MenuGroup menuGroup)
        {
            menuGroupService.UpdateMenuGroup(menuGroup);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteMenuGroup))]
        public IActionResult DeleteMenuGroup(int id)
        {
            menuGroupService.DeleteMenuGroup(id);
            return Ok("Delete success");
        }
    }
}
