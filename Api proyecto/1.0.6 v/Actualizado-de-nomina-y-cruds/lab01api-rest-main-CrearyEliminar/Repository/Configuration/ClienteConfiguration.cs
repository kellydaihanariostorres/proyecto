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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData
            (
                new Cliente
                {
                    Id = new Guid("01fecba8-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Kelly",
                    Apellido = "Rios",
                    Edad = 30,
                    tipoDocumento = "CC",
                    numDocumento = 1013102042,
                    Correo = "rios.rios@gmail.com",
                },
                new Cliente
                {
                    Id = new Guid("01fecbc1-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Luna",
                    Apellido = "Mahecha",
                    Edad = 21,
                    tipoDocumento = "CC",
                    numDocumento = 1000257543,
                    Correo = "rios.rios@gmail.com",
                }
            ); ;
        }
    }
}