using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ProveedorDto(Guid Id, string Nombre, int numDocumento, int Edad, string Telefono, string Correo, string NombreEntidadBancaria, int NumeroCuentaBancaria);
    
}
