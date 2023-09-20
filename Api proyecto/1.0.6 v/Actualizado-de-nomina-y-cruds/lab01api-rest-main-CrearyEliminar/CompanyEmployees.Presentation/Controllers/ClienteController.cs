using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Presentation.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ClientesController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetClientes()
        {
            //throw new Exception("Exception");
            var clientes =
            _service.ServicioCliente.GetAllCliente(trackChanges: false);
            return Ok(clientes);

        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCliente(Guid id)
        {
            var cliente = _service.ServicioCliente.GetCliente(id, trackChanges: false);
            return Ok(cliente);
        }
    }
}