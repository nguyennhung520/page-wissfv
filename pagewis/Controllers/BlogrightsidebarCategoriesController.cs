using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.BlogrightsidebarCategoriesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogrightsidebarCategoriesController : ControllerBase
    {
        private readonly IBlogrightsidebarCategoriesService blogrightsidebarCategoriesService;
        public BlogrightsidebarCategoriesController(IBlogrightsidebarCategoriesService blogrightsidebarCategoriesService)
        {
            this.blogrightsidebarCategoriesService = blogrightsidebarCategoriesService;
        }
        [HttpGet(nameof(GetBlogrightsidebarCategories))]
        public IActionResult GetBlogrightsidebarCategories(int id)
        {
            var result = blogrightsidebarCategoriesService.GetBlogrightsidebarCategories(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllBlogrightsidebarCategories))]
        public IActionResult GetAllBlogrightsidebarCategories()
        {
            var result = blogrightsidebarCategoriesService.GetAllBlogrightsidebarCategories();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertBlogrightsidebarCategories))]
        public IActionResult InsertBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories)
        {
            blogrightsidebarCategoriesService.InSertBlogrightsidebarCategories(blogrightsidebarCategories);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateBlogrightsidebarCategories))]
        public IActionResult UpdateBlogrightsidebarCategories(BlogrightsidebarCategories blogrightsidebarCategories)
        {
            blogrightsidebarCategoriesService.UpdateBlogrightsidebarCategories(blogrightsidebarCategories);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteBlogrightsidebarCategories))]
        public IActionResult DeleteBlogrightsidebarCategories(int id)
        {
            blogrightsidebarCategoriesService.DeleteBlogrightsidebarCategories(id);
            return Ok("Delete success");
        }
    }
}
