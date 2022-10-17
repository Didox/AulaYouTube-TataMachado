using AulaYouTube.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaYouTube.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public Apresentacao Index(){
            return new Apresentacao();
        }
    }
}