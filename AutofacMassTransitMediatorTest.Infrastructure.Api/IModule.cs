using System.Threading.Tasks;
using Autofac;

namespace AutofacMassTransitMediatorTest.Infrastructure.Api
{
    public interface IModule
    {
        Task LoadAsync(ContainerBuilder containerBuilder);
    }
}