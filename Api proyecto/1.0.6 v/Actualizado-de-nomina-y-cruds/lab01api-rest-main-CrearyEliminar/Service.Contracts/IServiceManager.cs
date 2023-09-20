using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        
        IServiceFactura ServicioFactura { get; }
        IServiceNomina ServiceNomina { get; }
        IServicioProveedor ServcioProveedor { get; }
        IServicioCliente ServicioCliente { get; }
        IServicioBodega ServicioBodega { get; }
        IServicioEmpleado ServicioEmpleado { get; }
        IServicioProducto ServicioProducto { get; }
        IServicioInventario ServicioInventario { get; }
    }
}
