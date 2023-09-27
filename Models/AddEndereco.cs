using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Models
{
    public record AddEndereco(
        int cep,
        string rua,
        string bairro,
        string cidade,
        string estado
    )
    {
        
    }
}