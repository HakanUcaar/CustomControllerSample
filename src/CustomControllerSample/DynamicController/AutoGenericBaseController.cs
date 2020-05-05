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
        public virtual ActionResult<T> Add([FromBody]object Data)
        {
            var Dat = JsonSerializer.Deserialize<T>(Data.ToString());
            return Dat;
        }

        [HttpPost]
        public virtual ActionResult<T> AddAsyn([FromBody]object Data)
        {            
            return Task.Run(() =>
            {
                return JsonSerializer.Deserialize<T>(Data.ToString());
            }).Result;
        }
    }
}
