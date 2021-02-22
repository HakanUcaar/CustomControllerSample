using CustomControllerSample.DynamicController;
using CustomControllerSample.Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CustomControllerSample
{
    public static class AutoControllerServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoControllers(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddControllers();
            services.Configure(new Action<MvcOptions>(o => o.Conventions.Add(new AutoControllerRouteConvention())));

            var manager = GetServiceFromCollection<ApplicationPartManager>(services);
            if (!manager.FeatureProviders.OfType<AutoControllerFeatureProvider>().Any())
            {
                manager.FeatureProviders.Add(new AutoControllerFeatureProvider());
            }

            return services;
        }
        public static IServiceCollection AddAutoControllers(this IServiceCollection services, AutoControllerDbContext Context)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (Context == null)
            {
                throw new ArgumentNullException(nameof(Context));
            }

            services.AddControllers();
            var manager = GetServiceFromCollection<ApplicationPartManager>(services);
            if (!manager.FeatureProviders.OfType<AutoControllerFeatureProvider>().Any())
            {
                manager.FeatureProviders.Add(new AutoControllerFeatureProvider());
            }
            services.Configure(new Action<MvcOptions>(o => o.Conventions.Add(new AutoControllerRouteConvention())));


            return services;
        }

        private static T GetServiceFromCollection<T>(IServiceCollection services)
        {
            return (T)services
                .LastOrDefault(d => d.ServiceType == typeof(T))
                ?.ImplementationInstance;
        }

        public static IServiceCollection UseSqlServer(this IServiceCollection services,string connectionString)
        {
            services
                .AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
