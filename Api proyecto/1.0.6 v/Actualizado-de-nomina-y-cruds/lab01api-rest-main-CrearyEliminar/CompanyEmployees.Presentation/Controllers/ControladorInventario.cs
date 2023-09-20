using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CompanyEmployees.Presentation.Controllers
{
    [ApiController]
    [Route("api/inventarios")]
    public class ControladorIventario : ControllerBase
    {
        private readonly IServiceManager _service;

        public ControladorIventario(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetallInventarios()
        {
            //throw new Exception("Exception");
            var inventarios = _service.ServicioInventario.GetAllInventarios(trackChanges: false);
            return Ok(inventarios);


        }
        [HttpGet("{id:guid}")]
        public IActionResult GetInventario(Guid id)
        {
            var inventario = _service.ServicioInventario.GetInventario(id, trackChanges: false);
            return Ok(inventario);
        }
    }
}
