using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string sobrenome, string email, bool comunicado)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Comunicado = comunicado;
            DataCadastro = DateTime.Now;
            Enderecos = new List<Endereco>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public bool Comunicado { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public List<Endereco> Enderecos { get; private set; }


        public void Alterar(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Alterar(string nome, string sobrenome, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
        }

    }
}