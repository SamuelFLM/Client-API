using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string sobrenome, int idade, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Email = email;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public int Idade { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }

    }
}