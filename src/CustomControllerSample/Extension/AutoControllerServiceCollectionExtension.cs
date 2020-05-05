using CustomControllerSample.DynamicController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CustomControllerSample
{
    public static class AutoControllerServiceCollectionExtension
    {
        public static IMvcBuilder AddAutoController(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.AddMvcOptions(opt => { opt.Conventions.Add(new AutoControllerRouteConvention()); });

            if (!builder.PartManager.FeatureProviders.OfType<AutoControllerFeatureProvider>().Any())
            {
                builder.PartManager.FeatureProviders.Add(new AutoControllerFeatureProvider());
            }

            return builder;
        }
    }
}
