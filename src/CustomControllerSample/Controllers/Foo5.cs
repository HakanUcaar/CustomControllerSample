using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.Controllers
{
    [NonController]
    [Route("api/[controller]")]
    public class Foo5 : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "beta";
        }
    }
}
