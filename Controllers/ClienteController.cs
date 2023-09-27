using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Person.API.Entities;
using Person.API.Models;
using Person.API.Persistence;

namespace Person.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var get = _context.Clientes;
            return Ok(get);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(x => x.Id == id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Post(AddCliente add)
        {
            Cliente cliente = new Cliente(
                add.nome,
                add.sobrenome,
                add.idade,
                add.email
            );

            if (cliente.Nome.Length > 30)
                return BadRequest();
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateCliente update)
        {
            var clienteId = _context.Clientes.SingleOrDefault(x => x.Id == id);

            if (clienteId == null)
                return NotFound();

            clienteId.Alterar(update.nome, update.sobrenome, update.idade, update.email);

            _context.Clientes.Update(clienteId);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var clienteId = _context.Clientes.SingleOrDefault(x => x.Id == id);

            if (clienteId == null)
                return NotFound();

            _context.Clientes.Remove(clienteId);

            _context.SaveChanges();

            return NoContent();


        }
    }
}