using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using AutofacMassTransitMediatorTest.Core;
using AutofacMassTransitMediatorTest.Core.Publishers;
using AutofacMassTransitMediatorTest.Hardware;
using AutofacMassTransitMediatorTest.Infrastructure.Api;
using AutofacMassTransitMediatorTest.Infrastructure.Api.Messages;
using Microsoft.Extensions.DependencyInjection;

namespace AutofacMassTransitMediatorTest.Infrastructure
{
    public sealed class WorkerService
    {
        private IContainer _container;
        
        public async Task StartAsync()
        {
            var modules = GetModules().ToArray();
            
            var containerBuilder = new ContainerBuilder();
            
            foreach (var module in modules)
            {
                await module.LoadAsync(containerBuilder);
            }
            
            MassTransitModule.Load(GetModuleTypes(), containerBuilder);

            _container = containerBuilder.Build();
            
            var publisher = _container.Resolve<CorePublisher<IPrintReceiptMessage>>();
            await publisher.Publish(new PrintReceiptMessage("Hey there!"));

            Console.ReadLine();
        }

        public async Task StopAsync()
        {
            _container?.Dispose();
        }

        private static IEnumerable<IModule> GetModules()
        {
            yield return new HardwareModule();
            yield return new CoreModule();
        }

        private static IEnumerable<Type> GetModuleTypes()
        {
            yield return typeof(HardwareModule);
            yield return typeof(CoreModule);
        }
    }
}