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
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>
    {
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
            builder.HasData(
                new Bodega
                {
                    BodegaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Nombre = "Candela",
                    Estado = "Activo",
                    Direccion = "Calle 95#75-05",
                    Ciudad = "Bogota D.C"
                },
                new Bodega
                {
                    BodegaId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Nombre = "Paacifico",
                    Estado = "Inactivo",
                    Direccion = "Calle 59 B Bis # 37-49",
                    Ciudad = "Medellin"
                }
            );
        }
    }
}
