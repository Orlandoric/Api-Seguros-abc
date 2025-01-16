using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        //Mapeo del modelo producto con la tabla producto
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
          //optionsBuilder.UseSqlServer("Server=SISTEMA\\SQLEXPRESS02;Database=Seguros;Trusted_Connection=True");
          base.OnConfiguring(optionsBuilder);
        }

    }
}
