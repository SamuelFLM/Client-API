using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Models
{
    public record UpdateCliente(
        string nome,
        string sobrenome,
        int idade,
        string email
    )
    {
        
    }
}