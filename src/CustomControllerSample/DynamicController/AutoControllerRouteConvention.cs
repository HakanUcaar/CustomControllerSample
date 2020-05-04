using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection;

namespace CustomControllerSample.DynamicController
{
    public class AutoControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                var genericType = controller.ControllerType.GenericTypeArguments[0];
                var customNameAttribute = genericType.GetCustomAttribute<AutoControllerAttribute>();

                if (!(customNameAttribute?.Route == null || customNameAttribute?.Route == string.Empty))
                {
                    controller.Selectors.Add(new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel(new RouteAttribute(customNameAttribute.Route)),
                    });
                }
                else
                {
                    controller.ControllerName = genericType.Name;
                }
            }
        }
    }
}
