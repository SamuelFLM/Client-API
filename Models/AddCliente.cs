using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.API.Models
{
    public record AddCliente(
        string nome,
        string sobrenome,
        string email,
        bool comunicado
    )
    {
        
    }
}