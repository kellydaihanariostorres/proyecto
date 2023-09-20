using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
       
        private readonly Lazy<IRepositorioFactura> _repositorioFactura;
        private readonly Lazy<IRepositorioNomina> _repositorioNomina;
        private readonly Lazy<IProveedorRepositorio> _repositorioProveedor;
        private readonly Lazy<IClienteRepositorio> _repositorioCliente;
        private readonly Lazy<IBodegaRepositorio> _bodegaRepositorio;
        private readonly Lazy<IEmpleadoRepositorio> _empleadoRepositorio;
        private readonly Lazy<IProductoRepositorio> _productoRepositorio;
        private readonly Lazy<IInventarioRepositorio> _inventarioRepositorio;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _companyRepository = new Lazy<ICompanyRepository>(() => new
            CompanyRepository(repositoryContext));

            

            _repositorioFactura = new Lazy<IRepositorioFactura>(() => new
            RepositorioFactura(repositoryContext));

            _repositorioNomina = new Lazy<IRepositorioNomina>(() => new
            RepositorioNomina(repositoryContext));

            _repositorioProveedor = new Lazy<IProveedorRepositorio>(() => new
            RepositoryProveedor(repositoryContext));

            _repositorioCliente = new Lazy<IClienteRepositorio>(() => new
            RepositoryCliente(repositoryContext));
            _repositoryContext = repositoryContext;

            _bodegaRepositorio = new Lazy<IBodegaRepositorio>(() => new
            BodegaRepositorio(repositoryContext));

            _empleadoRepositorio = new Lazy<IEmpleadoRepositorio>(() => new
            EmpleadoRepositorio(repositoryContext));

            _productoRepositorio = new Lazy<IProductoRepositorio>(() => new
            ProductoRepositorio(repositoryContext));

            _inventarioRepositorio = new Lazy<IInventarioRepositorio>(() => new
            InventarioRepositorio(repositoryContext));
        }

        public ICompanyRepository Company => _companyRepository.Value;


        
        public IRepositorioFactura Factura => _repositorioFactura.Value;
        public IRepositorioNomina Nomina => _repositorioNomina.Value;

        public IProveedorRepositorio Proveedor => _repositorioProveedor.Value;
        public IClienteRepositorio Cliente => _repositorioCliente.Value;
        public IBodegaRepositorio Bodega => _bodegaRepositorio.Value;
        public IEmpleadoRepositorio Empleado => _empleadoRepositorio.Value;
        public IProductoRepositorio Producto => _productoRepositorio.Value;
        public IInventarioRepositorio Inventario => _inventarioRepositorio.Value;
        public void Save()
        => _repositoryContext.SaveChanges();

    }
}
