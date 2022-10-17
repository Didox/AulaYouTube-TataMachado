using System.Collections.Generic;
using AulaYouTube.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaYouTube.Controllers
{
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [Route("/clientes")]
        public ActionResult Index(){
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente(){
                Id = 1,
                Nome = "Daniel",
                Email = "danilo@gmail.com",
                Telefone = "(00)00000-0000"
            });

            clientes.Add(new Cliente(){
                Id = 1,
                Nome = "Samoel",
                Email = "samoel@gmail.com",
                Telefone = "(00)00000-0001"
            });

            return StatusCode(200, clientes);
        }
    }
}