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
    public class ConfiguracionNomina : IEntityTypeConfiguration<Nomina>
    {
        public void Configure(EntityTypeBuilder<Nomina> builder)
        {
            builder.HasData(
                new Nomina
                {
                    NominaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                    CuentaBancaria = "1234567890",
                    Email = "correo@example.com",
                    Telefono = "555-123-4567",
                    Direccion = "123 Calle Principal",
                    FechaCreacion = DateTime.Now
                },
                new Nomina
                {
                    NominaId = new Guid("376D45C8-659D-4ACE-B249-CFBF4F231915"),
                    CuentaBancaria = "1234567890",
                    Email = "otrocorreo@example.com",
                    Telefono = "555-987-6543",
                    Direccion = "456 Calle Secundaria",
                    FechaCreacion = DateTime.Now
                }

            );
        }
    }
}
