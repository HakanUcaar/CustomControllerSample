using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class MyCustomController 
    { 

    }

    public class Foo4 : MyCustomController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Foo4 World";
        }
    }
}
