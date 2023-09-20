using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasData
            (
                new Proveedor
                {
                    Id = new Guid("01bbcdef-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Juan",
                    numDocumento= 1013102042,
                    Edad = 30,
                    Direccion = "Cra 43i #50-32 sur",
                    Telefono = "3512255454",
                    Correo = "Juan0212@gmail.com",
                    NombreEntidadBancaria = "Bancolombia",
                    NumeroCuentaBancaria = 0478543462,
                },
                new Proveedor
                {
                    Id = new Guid("00abc238-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Pedro",
                    numDocumento = 1000257543,
                    Edad = 30,
                    Direccion = "Cll 10c #11-32",
                    Telefono = "3623568478",
                    Correo = "Pedroxd@gmail.com",
                    NombreEntidadBancaria = "BancoBogotá",
                    NumeroCuentaBancaria = 52246-545-545,
                }

            );;
        }
    }
}