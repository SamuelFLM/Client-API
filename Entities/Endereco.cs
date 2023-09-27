using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Entities
{
    public class Endereco
    {
        public Endereco(int cep, string rua, string bairro, string cidade, string estado)
        {
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public int Id { get; private set; }
        public int Cep { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int IdCliente { get; private set; }
        //To-do - api cep
        public void Alterar()
        {

        }
    }
}