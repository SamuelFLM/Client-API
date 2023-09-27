using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Person.API.Entities;

namespace Person.API.Persistence.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        void Adicionar(Cliente cliente);
        void AdicionarEndereco(Endereco endereco);
        void Alterar(Cliente cliente);
        void AlterarEndereco(Endereco endereco);
        void Deletar(Cliente cliente);
        void DeletarEndereco(Endereco endereco);
    }
}