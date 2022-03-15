using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.Models;

namespace SistemaFacturacion.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Facturas> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\FacturacionDB.db");
        }
    }
}
