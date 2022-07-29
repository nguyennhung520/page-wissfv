using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.RoBertAIReviewsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoBertAIReviewsController : ControllerBase
    {
        private readonly IRoBertAIReviewsService roBertAIReviewsService;
        public RoBertAIReviewsController(IRoBertAIReviewsService roBertAIReviewsService)
        {
            this.roBertAIReviewsService = roBertAIReviewsService;
        }
        [HttpGet(nameof(GetRoBertAIReviews))]
        public IActionResult GetRoBertAIReviews(int id)
        {
            var result = roBertAIReviewsService.GetRoBertAIReviews(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllRoBertAIReviews))]
        public IActionResult GetAllRoBertAIReviews()
        {
            var result = roBertAIReviewsService.GetAllRoBertAIReviews();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertRoBertAIReviews))]
        public IActionResult InsertRoBertAIReviews(RoBertAIReviews roBertAIReviews)
        {
            roBertAIReviewsService.InsertRoBertAIReviews(roBertAIReviews);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateRoBertAIReviews))]
        public IActionResult UpdateRoBertAIReviews(RoBertAIReviews roBertAIReviews)
        {
            roBertAIReviewsService.UpdateRoBertAIReviews(roBertAIReviews);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteRoBertAIReviews))]
        public IActionResult DeleteRoBertAIReviews(int id)
        {
            roBertAIReviewsService.DeleteRoBertAIReviews(id);
            return Ok("Delete success");
        }
    }
}
