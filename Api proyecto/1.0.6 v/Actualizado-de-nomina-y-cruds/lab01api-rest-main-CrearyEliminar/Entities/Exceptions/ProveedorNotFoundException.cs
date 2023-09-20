using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class ProveedorNotFoundException : NotFoundException
    {
        public ProveedorNotFoundException(Guid ProveedorId)
            : base($"El proveedor con el id:{ProveedorId} no existe en la base de datos.")
        {
        }
    }
}
