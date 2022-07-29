using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.BlogrightsidebarIntroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogrightsidebarIntroController : ControllerBase
    {
        private readonly IBlogrightsidebarIntroService blogrightsidebarIntroService;
        public BlogrightsidebarIntroController(IBlogrightsidebarIntroService blogrightsidebarIntroService)
        {
            this.blogrightsidebarIntroService = blogrightsidebarIntroService;
        }
        [HttpGet(nameof(GetBlogrightsidebarIntro))]
        public IActionResult GetBlogrightsidebarIntro(int id)
        {
            var result = blogrightsidebarIntroService.GetBlogrightsidebarIntro(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllBlogrightsidebarIntro))]
        public IActionResult GetAllBlogrightsidebarIntro()
        {
            var result = blogrightsidebarIntroService.GetAllBlogrightsidebarIntro();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertBlogrightsidebarIntro))]
        public IActionResult InsertBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro)
        {
            blogrightsidebarIntroService.InSertBlogrightsidebarIntro(blogrightsidebarIntro);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateBlogrightsidebarIntro))]
        public IActionResult UpdateBlogrightsidebarIntro(BlogrightsidebarIntro blogrightsidebarIntro)
        {
            blogrightsidebarIntroService.UpdateBlogrightsidebarIntro(blogrightsidebarIntro);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteBlogrightsidebarIntro))]
        public IActionResult DeleteBlogrightsidebarIntro(int id)
        {
            blogrightsidebarIntroService.DeleteBlogrightsidebarIntro(id);
            return Ok("Delete success");
        }
    }
}
