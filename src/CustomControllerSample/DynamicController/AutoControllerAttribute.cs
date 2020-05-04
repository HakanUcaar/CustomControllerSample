using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomControllerSample.DynamicController
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AutoControllerAttribute : Attribute
    {
        public AutoControllerAttribute(string Route="")
        {
            this.Route = Route;
        }
        public string Route { get; set; }
    }
}
