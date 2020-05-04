using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CustomControllerSample.DynamicController
{
    public class AutoControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            foreach (var part in parts.OfType<IApplicationPartTypeProvider>())
            {
                foreach (var type in part.Types)
                {                    
                    if (type.AsType().GetCustomAttributes<AutoControllerAttribute>().Any() 
                        && !feature.Controllers.Contains(type))
                    {
                        feature.Controllers.Add
                            (
                                typeof(AutoGenericBaseController<>).MakeGenericType(type).GetTypeInfo()
                            );
                    }
                }
            }
        }
    }
}
