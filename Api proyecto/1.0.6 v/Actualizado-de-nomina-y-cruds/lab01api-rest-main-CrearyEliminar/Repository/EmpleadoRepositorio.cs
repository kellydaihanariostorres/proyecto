using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmpleadoRepositorio : RepositoryBase<Empleado>, IEmpleadoRepositorio
    {
        public EmpleadoRepositorio(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {

        }
        public IEnumerable<Empleado> GetAllEmpleados(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(e => e.Nombre)
           .ToList();

        public IEnumerable<Empleado> GetEmpleados(Guid bodegaId, bool trackChanges) =>
         FindByCondition(e => e.BodegaId.Equals(bodegaId), trackChanges)
         .OrderBy(e => e.Nombre).ToList();


        public Empleado GetEmpleado(Guid empleadoId, bool trackChanges) =>
        FindByCondition(c => c.EmpleadoId.Equals(empleadoId), trackChanges)
        .SingleOrDefault();

        public Empleado GetEmpleado(Guid bodegaId, Guid empleadoId, bool trackChanges) =>
         FindByCondition(e => e.BodegaId.Equals(bodegaId) && e.EmpleadoId.Equals(empleadoId),
        trackChanges)
         .SingleOrDefault();

        public void CrearEmpleado(Empleado empleado) => Create(empleado);
        public void EliminarEmpleado(Empleado empleado) => Delete(empleado);
    }
}
