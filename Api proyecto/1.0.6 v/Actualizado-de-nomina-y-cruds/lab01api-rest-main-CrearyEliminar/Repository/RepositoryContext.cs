using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext :DbContext
    {

        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            
            modelBuilder.ApplyConfiguration(new ConfiguracionFactura());
            modelBuilder.ApplyConfiguration(new ConfiguracionNomina());
            modelBuilder.ApplyConfiguration(new ProveedorConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new BodegaConfiguracion());
            modelBuilder.ApplyConfiguration(new EmpleadoConfiguracion());
            modelBuilder.ApplyConfiguration(new ProductoConfiguracion());
            modelBuilder.ApplyConfiguration(new InventarioConfiguracion());
        }

        public DbSet<Company>? Companies { get; set; }
      
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Bodega>? Bodegas { get; set; }
        public DbSet<Empleado>? Empleados { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Inventario>? Inventarios { get; set; }


    }
}
