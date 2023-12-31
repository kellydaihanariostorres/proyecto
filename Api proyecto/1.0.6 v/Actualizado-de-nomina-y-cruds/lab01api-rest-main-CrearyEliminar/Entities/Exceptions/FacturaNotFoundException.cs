﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class FacturaNotFoundException : NotFoundException
    {
        public FacturaNotFoundException(Guid facturaId)
            : base($"la factura id:{facturaId} no existe en la base de datos.")
        {
        }
    }
}
