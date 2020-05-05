using CustomControllerSample.DynamicController;
using CustomControllerSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

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
        public override T Add([FromBody]object Data)
        {
            var Dat = JsonSerializer.Deserialize<T>(Data.ToString());

            Context.Set<T>().Add(Dat);
            Context.SaveChanges();
            return Dat;
        }
    }
}
