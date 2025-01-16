using Business.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AseguradoraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        ICliente _cliente;

        //Instancia de la interfase
        public ClienteController(ICliente cliente) 
        {
            _cliente = cliente;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _cliente.GetClientes();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" ;
            
        }

        // POST api/<ClienteController>
        [HttpPost]
        public string Post([FromBody] Cliente value)
        {
            return _cliente.SetCliente(value);
        }

        // PUT api/<ClienteController>/5
        [HttpPut] //("{id}")
        public string Put( Cliente value) //int id, [FromBody]
        {
            return _cliente.UpdateCliente(value);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _cliente.DeleteCliente(id);
        }
    }
}
