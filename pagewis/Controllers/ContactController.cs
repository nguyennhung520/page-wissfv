using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ContactService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagewis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet (nameof(GetContact))]
        public IActionResult GetContact(int id)
        {
            var result = contactService.GetContact(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet (nameof(GetAllContact))]
        public IActionResult GetAllContact()
        {
            var result = contactService.GetAllContact();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertContact))]
        public IActionResult InsertContact(Contact contact)
        {
            contactService.InsertContact(contact);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateContact))]
        public IActionResult UpdateContact(Contact contact)
        {
            contactService.UpdateContact(contact);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteContact))]
        public IActionResult DeleteContact(int id)
        {
            contactService.DeleteContact(id);
            return Ok("Delete success");
        }
    }
}
