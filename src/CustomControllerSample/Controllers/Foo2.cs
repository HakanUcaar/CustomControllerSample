using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.Controllers
{
    [Route("api/[controller]")]
    public class Foo2Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Bu Foo2 denetcisidir";
        }
    }
}
