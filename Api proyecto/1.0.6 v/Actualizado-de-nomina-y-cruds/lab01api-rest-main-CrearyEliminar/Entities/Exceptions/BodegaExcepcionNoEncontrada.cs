using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class BodegaExcepcionNoEncontrada : NotFoundException
    {
        public BodegaExcepcionNoEncontrada(Guid bodegaId) 
        : base($"La bodega con el id:{bodegaId} no existe en la base de datos.")
        {
        }
    }
}
