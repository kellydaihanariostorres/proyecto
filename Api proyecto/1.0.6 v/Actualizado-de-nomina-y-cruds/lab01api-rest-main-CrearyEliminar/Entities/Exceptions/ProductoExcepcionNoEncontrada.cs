using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
   public sealed class ProductoExcepcionNoEncontrada : NotFoundException
   {
        public ProductoExcepcionNoEncontrada(Guid productoId)
            : base($"El producto con id:{productoId} no existe en la base de datos.")
        {
        }
   }
}
