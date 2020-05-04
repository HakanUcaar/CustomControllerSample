using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.Controllers
{
    [Route("api/[controller]")]
    public class Foo1Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Bu "+ControllerContext.ActionDescriptor.ControllerName+" denetcisidir";
        }
    }
}
