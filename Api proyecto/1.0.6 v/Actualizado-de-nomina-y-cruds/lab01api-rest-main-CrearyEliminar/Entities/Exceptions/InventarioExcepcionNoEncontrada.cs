using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class InventarioExcepcionNoEncontrada : NotFoundException
    {
        public InventarioExcepcionNoEncontrada(Guid inventarioId)
            : base($"La inventario con el id:{inventarioId} no existe en la base de datos.")
        {

        }
    }
}