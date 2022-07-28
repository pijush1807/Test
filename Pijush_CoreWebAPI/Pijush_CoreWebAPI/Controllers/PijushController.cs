using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pijush_CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PijushController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Harsh sir,Get method run successfully";
        }
        [HttpPost]
        public string Post(string? name)
        {
            return "Hello Harsh sir, I am " + name + " Saved my name";
        }
    }
}
