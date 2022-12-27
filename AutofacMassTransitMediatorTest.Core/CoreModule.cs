using System.Threading.Tasks;
using Autofac;
using AutofacMassTransitMediatorTest.Core.Publishers;
using AutofacMassTransitMediatorTest.Infrastructure.Api;
using AutofacMassTransitMediatorTest.Infrastructure.Api.Messages;

namespace AutofacMassTransitMediatorTest.Core
{
    public sealed class CoreModule : IModule
    {
        public Task LoadAsync(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CorePublisher<IPrintReceiptMessage>>();
            return Task.CompletedTask;
        }
    }
}