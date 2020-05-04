using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class Foo3
    {
        [HttpGet]
        public string Get()
        {
            return "Bu Foo3 denetcisidir";
        }
    }
}
