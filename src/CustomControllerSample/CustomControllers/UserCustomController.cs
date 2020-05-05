using CustomControllerSample.DynamicController;
using CustomControllerSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomControllerSample.CustomControllers
{
    public class UserCustomController<T> : AutoGenericBaseController<T> where T : class
    {
        private DbContext Context { get; }

        public UserCustomController(DbContext Context)
        {
            this.Context = Context;
        }

        [HttpGet]
        public string GetTestAction()
        {
            return "Test Method Başarılı";
        }

        [HttpPost]
        public override ActionResult<T> Add([FromBody]object Data)
        {
            var Dat = JsonSerializer.Deserialize<T>(Data.ToString());

            Context.Set<T>().Add(Dat);
            Context.SaveChanges();
            return Dat;
        }

        [HttpPost]
        public override ActionResult<T> AddAsyn([FromBody]object Data)
        {
            return Task.Run(() =>
            {
                var Dat = JsonSerializer.Deserialize<T>(Data.ToString());

                Context.Set<T>().AddAsync(Dat);
                Context.SaveChanges();
                return Dat;
            }).Result;
        }
    }
}
