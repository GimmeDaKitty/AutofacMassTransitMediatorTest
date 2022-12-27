using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace AutofacMassTransitMediatorTest.Infrastructure
{
    public class MassTransitModule
    {
        public static void Load(IEnumerable<Type> moduleTypes, ContainerBuilder builder)
        {
            var collection = new ServiceCollection()
                .AddMediator(cfg =>
                {
                    cfg.AddConsumers(moduleTypes
                        .Select(Assembly.GetAssembly)
                        .ToArray());

                });
            
            builder.Populate(collection);
        }
    }
}