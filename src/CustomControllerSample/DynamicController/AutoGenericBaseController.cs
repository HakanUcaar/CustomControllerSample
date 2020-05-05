using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomControllerSample.DynamicController
{
    [Route("api/[controller]/[action]")]
    public class AutoGenericBaseController<T> : ControllerBase where T : class
    {
        [HttpGet]
        public string Get()
        {
            return "Bu " + typeof(T).Name + " denetcisidir";
        }    

        [HttpPost]
        public virtual T Add([FromBody]object Data)
        {
            var Dat = JsonSerializer.Deserialize<T>(Data.ToString());
            return Dat;
        }
    }
}
