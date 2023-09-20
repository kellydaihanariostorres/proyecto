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
    public class ProductoConfiguracion : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.HasData(
                new Productos
                {
                    Id = new Guid("80abbca8-664d-4b21-b5de-024705497d4a"),
                    NombreProducto = "Poker ",
                    PrecioProducto = "3000",
                    MarcaProducto = "Poker",
                    ClasificacionProducto = "Cerveza",
                    
                },
                 new Productos
                 {
                     Id = new Guid("80abbca5-664d-4b22-b5de-024705497d4a"),
                     NombreProducto = "Gato Negro ",
                     PrecioProducto = "20000",
                     MarcaProducto = "Gato Negro",
                     ClasificacionProducto = "Vino",
                 },

                 new Productos
                 {
                     Id = new Guid("80abbca4-664d-4b23-b5de-024705497d4a"),
                     NombreProducto = "Jack Dniel's ",
                     PrecioProducto = "50000",
                     MarcaProducto = "Jack Dniel's",
                     ClasificacionProducto = "whisky",
                 }
            );
        }
    }
}
