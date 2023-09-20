using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        
        private readonly Lazy<IServiceFactura> _serviceFactura;
        private readonly Lazy<IServiceNomina> _serviceNomina;
        private readonly Lazy<IServicioProveedor> _servicioProveedor;
        private readonly Lazy<IServicioCliente> _servicioCliente;
        private readonly Lazy<IServicioBodega> _ServicioBodega;
        private readonly Lazy<IServicioEmpleado> _ServicioEmpleado;
        private readonly Lazy<IServicioProducto> _ServicioProducto;
        private readonly Lazy<IServicioInventario> _ServicioInventario;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger, mapper));
            
            _serviceFactura = new Lazy<IServiceFactura>(() => new ServicioFactura(repositoryManager, logger, mapper));
            _serviceNomina = new Lazy<IServiceNomina>(() => new ServicioNomina(repositoryManager, logger, mapper));
            _servicioProveedor = new Lazy<IServicioProveedor>(() => new ServicioProveedor(repositoryManager, logger, mapper));
            _servicioCliente = new Lazy<IServicioCliente>(() => new ServicioCliente(repositoryManager, logger, mapper));
            _ServicioBodega = new Lazy<IServicioBodega>(() => new ServicioBodega(repositoryManager, logger, mapper));
            _ServicioEmpleado = new Lazy<IServicioEmpleado>(() => new ServicioEmpleado(repositoryManager, logger, mapper));
            _ServicioProducto = new Lazy<IServicioProducto>(() => new ServicioProducto(repositoryManager, logger, mapper));
            _ServicioInventario = new Lazy<IServicioInventario>(() => new ServicioInventario(repositoryManager, logger, mapper));
        }

        public ICompanyService CompanyService => _companyService.Value;
        

        public IServiceFactura ServicioFactura => _serviceFactura.Value;
        public IServiceNomina ServiceNomina => _serviceNomina.Value;
        public IServicioCliente ServicioCliente => _servicioCliente.Value;
        public IServicioProveedor ServcioProveedor => _servicioProveedor.Value;
        public IServicioBodega ServicioBodega => _ServicioBodega.Value;
        public IServicioEmpleado ServicioEmpleado => _ServicioEmpleado.Value;
        public IServicioProducto ServicioProducto => _ServicioProducto.Value;
        public IServicioInventario ServicioInventario => _ServicioInventario.Value;
    }
}
