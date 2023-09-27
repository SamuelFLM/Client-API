using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person.API.Entities;

namespace Person.API.Persistence.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly ClienteContext _context;

        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }


        public void Alterar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void AlterarEndereco(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            _context.SaveChanges();
        }

        public void Deletar(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public void DeletarEndereco(Endereco endereco)
        {
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
        }

        public Cliente ObterPorId(int id)
        {
            return _context.Clientes
                    .Include(x => x.Enderecos)
                    .SingleOrDefault(x => x.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}