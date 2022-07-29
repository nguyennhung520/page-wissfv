using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.LoginFormService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginFormController : ControllerBase
    {
        private readonly ILoginFormService loginFormService;
        public LoginFormController(ILoginFormService loginFormService)
        {
            this.loginFormService = loginFormService;
        }
        [HttpGet(nameof(GetLoginForm))]
        public IActionResult GetLoginForm(int id)
        {
            var result = loginFormService.GetLoginForm(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllLoginForm))]
        public IActionResult GetAllLoginForm()
        {
            var result = loginFormService.GetAllLoginForm();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertLoginForm))]
        public IActionResult InsertLoginForm(LoginForm loginForm)
        {
            loginFormService.InsertLoginForm(loginForm);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateLoginForm))]
        public IActionResult UpdateLoginForm(LoginForm loginForm)
        {
            loginFormService.UpdateLoginForm(loginForm);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteLoginForm))]
        public IActionResult DeleteLoginForm(int id)
        {
            loginFormService.DeleteLoginForm(id);
            return Ok("Delete success");
        }
    }
}
