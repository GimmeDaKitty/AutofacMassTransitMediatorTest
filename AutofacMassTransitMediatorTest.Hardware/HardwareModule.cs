using System.Threading.Tasks;
using Autofac;
using AutofacMassTransitMediatorTest.Infrastructure.Api;

namespace AutofacMassTransitMediatorTest.Hardware
{
    public sealed class HardwareModule : IModule
    {
        public Task LoadAsync(ContainerBuilder containerBuilder)
        {
            return Task.CompletedTask;
        }
    }
}