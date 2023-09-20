using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Presentation.Controllers
{
   

    [Route("api/bodegas/{bodegaId}/empleados")]
    [ApiController]
    public class ControladorEmpleado : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorEmpleado(IServiceManager service) =>
            _service = service;

        [HttpGet("/api/empleados")]        
        public IActionResult GetEmpleados()
        {
            
            var empleados = _service.ServicioEmpleado.GetAllEmpleados(trackChanges: false);
            return Ok(empleados);
           
        }
        [HttpGet]
        public IActionResult GetEmpleadoParaBodega(Guid bodegaId)
        {
            var empleados = _service.ServicioEmpleado.GetEmpleados(bodegaId, trackChanges:false);
            return Ok(empleados);
        }

        [HttpGet("/api/empleados/{id:guid}", Name = "EmpleadoById")]
        public IActionResult GetEmpleado(Guid id)
        {
            var empleado = _service.ServicioEmpleado.GetEmpleado(id, trackChanges: false);
            return Ok(empleado);
        }
        [HttpPost("/api/empleados")]
        public IActionResult CrearEmpleado([FromBody] CrearEmpleadoDto empleado)
        {
            if (empleado is null)
                return BadRequest("El objeto CrearEmpleadoDto es nulo ");

            var crearempleado = _service.ServicioEmpleado.CrearEmpleado(empleado);

            return CreatedAtRoute("EmpleadoById", new { id = crearempleado.EmpleadoId }, crearempleado);
        }
        [HttpDelete("/api/empleados/{empleadoId:guid}")]
        public IActionResult EliminarEmpleadoDeBodega(Guid empleadoId)
        {
            _service.ServicioEmpleado.EliminarEmpleadoDeBodega( empleadoId, trackChanges:
            false);
            return NoContent();
        }

        [HttpPut("/api/empleados/{empleadoId:guid}")]
        public IActionResult ActualizarEmpleado(Guid empleadoId, [FromBody] ActualizarEmpleadoDto empleado)
        {
            if (empleado is null)
                return BadRequest("El objeto ActualizarEmpleadoDto es nulo");
            _service.ServicioEmpleado.ActualizarEmpleado(empleadoId, empleado, trackChanges: true);
            return NoContent();

        }
    }
}
