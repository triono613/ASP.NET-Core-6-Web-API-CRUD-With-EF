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

    }
}
