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
    public class InventarioConfiguracion : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.HasData(
                new Inventario
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    NombreProducto = "Gato Negro",
                    IdProducto = 222,
                    IdFactura = 777,
                    PrecioProducto = "20000",
                    CantidadProducto = 50,
                    MarcaProducto ="Gato Negro",
                    ClasificacionProducto = "Vino"
                }
       
            );
        }
    }
}
