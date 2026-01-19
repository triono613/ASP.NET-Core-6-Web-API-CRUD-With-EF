using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContacsController : ControllerBase
    {
        private ConnContext _connContext;
        public ContacsController(ConnContext _connContext) { this._connContext = _connContext; }

        [HttpGet]
        public async Task<ActionResult<Contacs>> getContact()
        {
            return Ok(await _connContext.Contacs.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(Contacs addContactRequest)
        {
            var contact = new Contacs
            {
                id = Guid.NewGuid(),
                name = addContactRequest.name,
                address = addContactRequest.address,
                email = addContactRequest.email,
                phone = addContactRequest.phone,
            };
            await _connContext.Contacs.AddAsync(contact);
            await _connContext.SaveChangesAsync();
            return Ok(contact); 
            // ok
        }

    }
}
