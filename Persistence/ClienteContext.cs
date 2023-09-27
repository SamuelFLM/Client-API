using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person.API.Entities;

namespace Person.API.Persistence
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}