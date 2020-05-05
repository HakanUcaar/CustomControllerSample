using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomControllerSample.DynamicController
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AutoControllerAttribute : Attribute
    {
        public string Route { get; set; }
        public Type BaseControllerType { get; set; }
        public AutoControllerAttribute(string Route = "", Type BaseControllerType = null)
        {
            this.Route = Route;
            this.BaseControllerType = BaseControllerType;
        }
    }
}
