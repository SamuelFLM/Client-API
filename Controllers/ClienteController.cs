using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Person.API.Persistence;

namespace Person.API.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _context;
        public ClienteController(ClienteContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Obter()
        {
            var cliente = _context.Clientes;
            return Ok(cliente);
        }

    }
}