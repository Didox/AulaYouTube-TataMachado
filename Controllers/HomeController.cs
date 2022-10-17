using AulaYouTube.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace AulaYouTube.Controllers
{


    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Apresentacao index()
        {
            return new Apresentacao();
        }

    }

}

