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
    public class EmpleadoConfiguracion : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado
                {
                    EmpleadoId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Sam ",
                    Apellido = "Raiden",
                    Documento = "165813218",
                    Cargo ="Analista",
                    FechaInicio = "15/03/2020",
                    FechaFin = "30/02/2023",
                    Sueldo = "55300000",
                    BodegaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                 new Empleado
                 {
                     EmpleadoId = new Guid("80abbca5-664d-4b20-b5de-024705497d4a"),
                     Nombre = "Johan",
                     Apellido = "Murcia",
                     Documento = "348651384",
                     Cargo = "Analista",
                     FechaInicio = "29/01/2020",
                     FechaFin = "30/02/2023",
                     Sueldo = "20000000",
                     BodegaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                 },

                 new Empleado
                 {
                     EmpleadoId = new Guid("80abbca4-664d-4b20-b5de-024705497d4a"),
                     Nombre = "Andres",
                     Apellido = "Rodriguez",
                     Documento = "15684283",
                     Cargo = "Analista",
                     FechaInicio = "25/09/2020",
                     FechaFin = "29/10/2022",
                     Sueldo = "1500000",
                     BodegaId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                 }
            );
        }
    }
}
