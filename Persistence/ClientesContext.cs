using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person.API.Entities;

namespace Person.API.Persistence
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>(e =>
            {
                e.HasKey(c => c.Id);
                e.HasMany(c => c.Enderecos)
                    .WithOne()
                    .HasForeignKey(c => c.IdCliente);
            });

            builder.Entity<Endereco>(e =>
            {
                e.HasKey(c => c.Id);
            });
        }

    }
}