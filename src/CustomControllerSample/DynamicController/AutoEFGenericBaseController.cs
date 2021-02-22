using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomControllerSample.DynamicController
{
    public class AutoEFGenericBaseController<T> : AutoGenericBaseController<T> where T :class
    {
        private DbContext Context { get; }
        public AutoEFGenericBaseController(DbContext Context)
        {
            this.Context = Context;
        }
    }
}
