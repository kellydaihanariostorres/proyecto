using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class ConfiguracionFactura : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.HasData(
                new Factura
                {
                    Id = new Guid("FD713788-B5AE-49FF-8B2C-F311B9CB0CC4"),
                    FechaCompra = DateTime.Now,
                    IVACompra = 0.18m,
                    Subtotal = 100.00m,
                    Total = 118.00m
                },

                new Factura
                {
                    Id = new Guid("64B512E7-46AE-4989-A049-A446118099C4"),
                    FechaCompra = DateTime.Now,
                    IVACompra = 0.18m,
                    Subtotal = 100.00m,
                    Total = 118.00m
                }

            );
        }
    }
}
