using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company {  get; }
       
        IRepositorioFactura Factura { get; }
        IRepositorioNomina Nomina { get; }
        IProveedorRepositorio Proveedor { get; }
        IClienteRepositorio Cliente { get; }
        IBodegaRepositorio Bodega { get; }
        IEmpleadoRepositorio Empleado { get; }
        IProductoRepositorio Producto { get; }
        IInventarioRepositorio Inventario { get; }
        void Save();
    }
}
