using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace APIRestLab01
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap < Company,CompanyDto>()
                .ForCtorParam("FullAddress",
                opt => opt.MapFrom(x => string.Join(' ',x.Address,x.Country)));

            CreateMap<Bodega, BodegaDto>();
            CreateMap<Empleado, EmpleadoDto>();
            CreateMap<Productos, ProductoDto>();
            CreateMap<Inventario, InventarioDto>();
            CreateMap<Factura, FacturaDto>();
            CreateMap<Nomina, NominaDto>();
            CreateMap<Proveedor, ProveedorDto>();
            CreateMap<Cliente, ClienteDto>();
            CreateMap<CrearBodegaDto, Bodega>();
            CreateMap<CrearEmpleadoDto, Empleado>();
            CreateMap<ActualizarBodegaDto, Bodega>();
            CreateMap<ActualizarEmpleadoDto, Empleado>();
        }
    }
}
