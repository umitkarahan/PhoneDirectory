using ContactInfo.Persistent.Entities;
using ContactService.Application.Interactions.Contacts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PhoneDirectory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<ContactEntity>> GetAll([FromServices] IMediator mediator)
        {
            return await mediator.Send(new GetAllContacts.Query());
        }

        [HttpPut]
        [ProducesResponseType(typeof(ContactEntity), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddNewContact([FromServices] IMediator mediator, [FromBody] ContactEntity contact)
        {
            var savedEntity = await mediator.Send(new CreateContact.Command() { Contact = contact });
            return Created(savedEntity.Uuid.ToString(), savedEntity);
        }
    }
}