using CL.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Cliente>()
            {
                new Cliente
                {
                    Id = 1,
                    Nome = "João do Caminhão",
                    DataNascimento = new DateTime(1980, 01, 01)
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "Maria do Caminhão",
                    DataNascimento = new DateTime(1990, 01, 01)
                }
            });
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
